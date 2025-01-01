namespace RapidFTPConfigurator {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.labelUsername = new System.Windows.Forms.Label();
      this.labelPassword = new System.Windows.Forms.Label();
      this.labelRootDir = new System.Windows.Forms.Label();
      this.labelPort = new System.Windows.Forms.Label();
      this.labelBindTo = new System.Windows.Forms.Label();
      this.textBoxUserName = new System.Windows.Forms.TextBox();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.textBoxRootDir = new System.Windows.Forms.TextBox();
      this.textBoxPort = new System.Windows.Forms.TextBox();
      this.textBoxBindTo = new System.Windows.Forms.TextBox();
      this.buttonConfirm = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelUsername
      // 
      this.labelUsername.AutoSize = true;
      this.labelUsername.Location = new System.Drawing.Point(24, 40);
      this.labelUsername.Name = "labelUsername";
      this.labelUsername.Size = new System.Drawing.Size(61, 13);
      this.labelUsername.TabIndex = 0;
      this.labelUsername.Text = "Username: ";
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Location = new System.Drawing.Point(24, 66);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(59, 13);
      this.labelPassword.TabIndex = 1;
      this.labelPassword.Text = "Password: ";
      // 
      // labelRootDir
      // 
      this.labelRootDir.AutoSize = true;
      this.labelRootDir.Location = new System.Drawing.Point(24, 91);
      this.labelRootDir.Name = "labelRootDir";
      this.labelRootDir.Size = new System.Drawing.Size(65, 13);
      this.labelRootDir.TabIndex = 2;
      this.labelRootDir.Text = "Root Folder:";
      // 
      // labelPort
      // 
      this.labelPort.AutoSize = true;
      this.labelPort.Location = new System.Drawing.Point(24, 117);
      this.labelPort.Name = "labelPort";
      this.labelPort.Size = new System.Drawing.Size(29, 13);
      this.labelPort.TabIndex = 0;
      this.labelPort.Text = "Port:";
      // 
      // labelBindTo
      // 
      this.labelBindTo.AutoSize = true;
      this.labelBindTo.Location = new System.Drawing.Point(24, 144);
      this.labelBindTo.Name = "labelBindTo";
      this.labelBindTo.Size = new System.Drawing.Size(47, 13);
      this.labelBindTo.TabIndex = 3;
      this.labelBindTo.Text = "Bind To:";
      // 
      // textBoxUserName
      // 
      this.textBoxUserName.Location = new System.Drawing.Point(93, 37);
      this.textBoxUserName.Name = "textBoxUserName";
      this.textBoxUserName.Size = new System.Drawing.Size(317, 20);
      this.textBoxUserName.TabIndex = 1;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(91, 63);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(319, 20);
      this.textBoxPassword.TabIndex = 2;
      // 
      // textBoxRootDir
      // 
      this.textBoxRootDir.Location = new System.Drawing.Point(91, 88);
      this.textBoxRootDir.Name = "textBoxRootDir";
      this.textBoxRootDir.Size = new System.Drawing.Size(319, 20);
      this.textBoxRootDir.TabIndex = 3;
      // 
      // textBoxPort
      // 
      this.textBoxPort.Location = new System.Drawing.Point(91, 114);
      this.textBoxPort.Name = "textBoxPort";
      this.textBoxPort.Size = new System.Drawing.Size(319, 20);
      this.textBoxPort.TabIndex = 4;
      // 
      // textBoxBindTo
      // 
      this.textBoxBindTo.Location = new System.Drawing.Point(91, 141);
      this.textBoxBindTo.Name = "textBoxBindTo";
      this.textBoxBindTo.Size = new System.Drawing.Size(319, 20);
      this.textBoxBindTo.TabIndex = 5;
      // 
      // buttonConfirm
      // 
      this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonConfirm.Location = new System.Drawing.Point(91, 176);
      this.buttonConfirm.Name = "buttonConfirm";
      this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
      this.buttonConfirm.TabIndex = 6;
      this.buttonConfirm.Text = "Confirm";
      this.buttonConfirm.UseVisualStyleBackColor = true;
      this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(335, 176);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 9;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(455, 224);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonConfirm);
      this.Controls.Add(this.textBoxBindTo);
      this.Controls.Add(this.textBoxPort);
      this.Controls.Add(this.textBoxRootDir);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxUserName);
      this.Controls.Add(this.labelBindTo);
      this.Controls.Add(this.labelPort);
      this.Controls.Add(this.labelRootDir);
      this.Controls.Add(this.labelPassword);
      this.Controls.Add(this.labelUsername);
      this.Name = "MainForm";
      this.Text = "Rapid FTP Configurator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelUsername;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.Label labelRootDir;
    private System.Windows.Forms.Label labelPort;
    private System.Windows.Forms.Label labelBindTo;
    private System.Windows.Forms.Button buttonConfirm;
    private System.Windows.Forms.Button buttonCancel;
    internal System.Windows.Forms.TextBox textBoxRootDir;
    internal System.Windows.Forms.TextBox textBoxUserName;
    internal System.Windows.Forms.TextBox textBoxPassword;
    internal System.Windows.Forms.TextBox textBoxPort;
    internal System.Windows.Forms.TextBox textBoxBindTo;
  }
}

