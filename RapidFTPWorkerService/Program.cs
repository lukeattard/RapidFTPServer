namespace RapidFTPWorkerService {
  public class Program {

    public static void Main(string[] args) {

      var builder = Host.CreateApplicationBuilder(args);
      builder.Services.AddHostedService<RapidFTP>();

      IHost host = Host.CreateDefaultBuilder(args)
        .UseWindowsService()
        .ConfigureServices(services => {
          services.AddHostedService<RapidFTP>();
        })
        .Build();
      host.Run();
    }
  }
}