using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidFTPConfigurator {
  internal class Code {

    internal static bool ConfirmPressed(MainForm mainForm) {
      try {
        if (mainForm.textBoxPassword.Text != null) {
          MainForm.settings.Password = mainForm.textBoxPassword.Text;
        }
        if (mainForm.textBoxUserName.Text != MainForm.settings.UserName) {
          MainForm.settings.UserName = mainForm.textBoxUserName.Text;
        }
        if (mainForm.textBoxPort.Text != MainForm.settings.Port.ToString()) {
          MainForm.settings.Port = Int32.Parse(mainForm.textBoxPort.Text);
        }
        if (mainForm.textBoxRootDir.Text != MainForm.settings.RootDir) {
          MainForm.settings.RootDir = mainForm.textBoxRootDir.Text;
        }
        if (mainForm.textBoxBindTo.Text != MainForm.settings.BindTo) {
          MainForm.settings.BindTo = mainForm.textBoxBindTo.Text;
        }

        MainForm.settings.UpdateSettings();

      } catch {
        return false;
      }
      return true;
    }
  }
}
