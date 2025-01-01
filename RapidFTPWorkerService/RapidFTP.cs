using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using FubarDev.FtpServer;
using FubarDev.FtpServer.AccountManagement;
using FubarDev.FtpServer.FileSystem.DotNet;
using Microsoft.Extensions.Logging;


namespace RapidFTPWorkerService {
  public class RapidFTP : BackgroundService {
    internal static RapidSettings settings = new RapidSettings();
    private readonly ILogger<RapidFTP> _logger;

    public ServiceProvider service;

    public RapidFTP(ILogger<RapidFTP> logger) {
      _logger = logger;
      service = new ServiceCollection().Configure<DotNetFileSystemOptions>(opt => opt.RootPath = settings.RootDir)
        .Configure<FtpServerOptions>(opt => { opt.ServerAddress = settings.BindTo; opt.Port = settings.Port; })
        .AddFtpServer(builder => builder.UseDotNetFileSystem())
        .AddSingleton<IMembershipProvider, CustomMembershipProvider>()
        .BuildServiceProvider();

      service.GetRequiredService<IFtpServerHost>().StartAsync(CancellationToken.None);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
      Console.WriteLine("Starting Rapid FTP Server");

      while (!stoppingToken.IsCancellationRequested) {
        if (_logger.IsEnabled(LogLevel.Information)) {
          _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        }
        await Task.Delay(1000, stoppingToken);
      }
      await service.GetRequiredService<IFtpServerHost>().StopAsync(CancellationToken.None);
    }
  }

  public class CustomMembershipProvider : IMembershipProvider {

    public Task<MemberValidationResult> ValidateUserAsync(string inputUsername, string inputPassword) {
      if ((RapidFTP.settings.UserName == "" && RapidFTP.settings.Password == "") || inputUsername == RapidFTP.settings.UserName && AuthCheck(inputPassword, RapidFTP.settings.Password)) {
        return Task.FromResult(new MemberValidationResult(MemberValidationStatus.AuthenticatedUser, new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, inputUsername) }))));
      }
      return Task.FromResult(new MemberValidationResult(MemberValidationStatus.InvalidLogin));
    }
    public static string GenerateHash(string input) {
      byte[] bytes = Encoding.UTF8.GetBytes(input + RapidSettings.getSalt);
      SHA256 sha = SHA256.Create();
      byte[] hash = sha.ComputeHash(bytes);
      return Convert.ToBase64String(hash);
    }

    public static bool AuthCheck(string plainTextInput, string hashedInput) {
      string newHashedPin = GenerateHash(plainTextInput);
      return newHashedPin.Equals(hashedInput);
    }
  }

}
