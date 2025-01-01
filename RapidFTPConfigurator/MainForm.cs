using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidFTPConfigurator {
  public partial class MainForm : Form {
    internal static RapidSettings settings = new RapidSettings();
    public MainForm() {
      InitializeComponent();
      textBoxUserName.Text = settings.UserName;
      textBoxPort.Text = settings.Port.ToString();
      textBoxBindTo.Text = settings.BindTo;
      textBoxRootDir.Text = settings.RootDir;
    }

    private void buttonConfirm_Click(object sender, EventArgs e) {
      if (Code.ConfirmPressed(this)) {
        this.Close();
      }
    }

    private void buttonCancel_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
