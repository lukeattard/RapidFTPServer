using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RapidFTPConfigurator {
  internal class RapidSettings {
    internal string currExe = System.Reflection.Assembly.GetExecutingAssembly().Location;
    internal string currPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ?? "NotFound";
    internal string ConfigPath { get; set; }
    internal string UserName { get; set; }
    
    internal string NewPassword { get; set; }
    internal int Port { get; set; }
    internal string BindTo { get; set; }
    internal string RootDir { get; set; }
    private static string salt = "ChangeME";
    internal static string getSalt { get { return salt; } }
    
    internal Microsoft.Win32.RegistryKey RegSettings = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\RapidData\RapidFTPServer");

    private string password;

    internal string Password {
      get {
        return password;
      } 
      
      set {
        password = GenerateHash(value);
        RegSettings.SetValue("Password", password);
      }
    }

    internal RapidSettings() {
      if (RegSettings.GetValue("ConfigPath") is null) {
        RegSettings.SetValue("ConfigPath", $"{currPath}\\RapidFTP.json");
      }

      this.ConfigPath = RegSettings.GetValue("ConfigPath")?.ToString() ?? $"{currPath}\\RapidFTP.json" ;
      this.UserName = RegSettings.GetValue("UserName")?.ToString() ?? "Demo";
      password = RegSettings.GetValue("Password")?.ToString() ?? "";
      string portString = RegSettings.GetValue("Port")?.ToString() ?? "21";
      this.Port = int.Parse(portString);
      this.BindTo = RegSettings.GetValue("BindTo")?.ToString() ?? "*";
      this.RootDir = RegSettings.GetValue("RootDir")?.ToString() ?? $"{currPath}\\Data";

    }
    public static string GenerateHash(string input) {
      byte[] bytes = Encoding.UTF8.GetBytes(input + RapidSettings.getSalt);
      SHA256 sha = SHA256.Create();
      byte[] hash = sha.ComputeHash(bytes);
      return Convert.ToBase64String(hash);
    }
    internal void UpdateSettings() {
      RegSettings.SetValue("UserName", UserName);
      RegSettings.SetValue("Password", password);
      RegSettings.SetValue("Port", Port.ToString());
      RegSettings.SetValue("BindTo", BindTo);
      RegSettings.SetValue("RootDir", RootDir);
    }
  }
}
