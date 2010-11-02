namespace ViddlerDemo
{
  partial class AuthPanel
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ConnectButton = new System.Windows.Forms.Button();
      this.separator1Label = new System.Windows.Forms.Label();
      this.PasswordText = new System.Windows.Forms.TextBox();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.UserNameText = new System.Windows.Forms.TextBox();
      this.userNameLabel = new System.Windows.Forms.Label();
      this.ApiKeyText = new System.Windows.Forms.TextBox();
      this.apiKeyLabel = new System.Windows.Forms.Label();
      this.SecureUrlText = new System.Windows.Forms.TextBox();
      this.secureUrlLabel = new System.Windows.Forms.Label();
      this.UrlText = new System.Windows.Forms.TextBox();
      this.urlLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // ConnectButton
      // 
      this.ConnectButton.BackColor = System.Drawing.SystemColors.Control;
      this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.ConnectButton.FlatAppearance.BorderSize = 0;
      this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.ConnectButton.Location = new System.Drawing.Point(0, 276);
      this.ConnectButton.Margin = new System.Windows.Forms.Padding(0);
      this.ConnectButton.Name = "ConnectButton";
      this.ConnectButton.Size = new System.Drawing.Size(300, 30);
      this.ConnectButton.TabIndex = 33;
      this.ConnectButton.Text = "Connect to Viddler";
      this.ConnectButton.UseVisualStyleBackColor = false;
      // 
      // separator1Label
      // 
      this.separator1Label.Dock = System.Windows.Forms.DockStyle.Top;
      this.separator1Label.Location = new System.Drawing.Point(0, 261);
      this.separator1Label.Name = "separator1Label";
      this.separator1Label.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.separator1Label.Size = new System.Drawing.Size(300, 15);
      this.separator1Label.TabIndex = 39;
      // 
      // PasswordText
      // 
      this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PasswordText.Dock = System.Windows.Forms.DockStyle.Top;
      this.PasswordText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.PasswordText.Location = new System.Drawing.Point(0, 240);
      this.PasswordText.Name = "PasswordText";
      this.PasswordText.PasswordChar = '*';
      this.PasswordText.Size = new System.Drawing.Size(300, 21);
      this.PasswordText.TabIndex = 32;
      this.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // passwordLabel
      // 
      this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.passwordLabel.Location = new System.Drawing.Point(0, 218);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.passwordLabel.Size = new System.Drawing.Size(300, 22);
      this.passwordLabel.TabIndex = 38;
      this.passwordLabel.Text = "Password:";
      // 
      // UserNameText
      // 
      this.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.UserNameText.Dock = System.Windows.Forms.DockStyle.Top;
      this.UserNameText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.UserNameText.Location = new System.Drawing.Point(0, 197);
      this.UserNameText.Name = "UserNameText";
      this.UserNameText.Size = new System.Drawing.Size(300, 21);
      this.UserNameText.TabIndex = 31;
      this.UserNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // userNameLabel
      // 
      this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.userNameLabel.Location = new System.Drawing.Point(0, 175);
      this.userNameLabel.Name = "userNameLabel";
      this.userNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.userNameLabel.Size = new System.Drawing.Size(300, 22);
      this.userNameLabel.TabIndex = 37;
      this.userNameLabel.Text = "User name:";
      // 
      // ApiKeyText
      // 
      this.ApiKeyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ApiKeyText.Dock = System.Windows.Forms.DockStyle.Top;
      this.ApiKeyText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.ApiKeyText.Location = new System.Drawing.Point(0, 154);
      this.ApiKeyText.Name = "ApiKeyText";
      this.ApiKeyText.Size = new System.Drawing.Size(300, 21);
      this.ApiKeyText.TabIndex = 30;
      this.ApiKeyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // apiKeyLabel
      // 
      this.apiKeyLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.apiKeyLabel.Location = new System.Drawing.Point(0, 132);
      this.apiKeyLabel.Name = "apiKeyLabel";
      this.apiKeyLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.apiKeyLabel.Size = new System.Drawing.Size(300, 22);
      this.apiKeyLabel.TabIndex = 36;
      this.apiKeyLabel.Text = "API key:";
      // 
      // SecureUrlText
      // 
      this.SecureUrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SecureUrlText.Dock = System.Windows.Forms.DockStyle.Top;
      this.SecureUrlText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.SecureUrlText.Location = new System.Drawing.Point(0, 111);
      this.SecureUrlText.Name = "SecureUrlText";
      this.SecureUrlText.Size = new System.Drawing.Size(300, 21);
      this.SecureUrlText.TabIndex = 29;
      this.SecureUrlText.Text = "https://api.viddler.com/api/v2/";
      this.SecureUrlText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // secureUrlLabel
      // 
      this.secureUrlLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.secureUrlLabel.Location = new System.Drawing.Point(0, 89);
      this.secureUrlLabel.Name = "secureUrlLabel";
      this.secureUrlLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.secureUrlLabel.Size = new System.Drawing.Size(300, 22);
      this.secureUrlLabel.TabIndex = 35;
      this.secureUrlLabel.Text = "Secure URL:";
      // 
      // UrlText
      // 
      this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.UrlText.Dock = System.Windows.Forms.DockStyle.Top;
      this.UrlText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.UrlText.Location = new System.Drawing.Point(0, 68);
      this.UrlText.Name = "UrlText";
      this.UrlText.Size = new System.Drawing.Size(300, 21);
      this.UrlText.TabIndex = 28;
      this.UrlText.Text = "http://api.viddler.com/api/v2/";
      this.UrlText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // urlLabel
      // 
      this.urlLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.urlLabel.Location = new System.Drawing.Point(0, 46);
      this.urlLabel.Name = "urlLabel";
      this.urlLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.urlLabel.Size = new System.Drawing.Size(300, 22);
      this.urlLabel.TabIndex = 34;
      this.urlLabel.Text = "URL:";
      // 
      // AuthPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ConnectButton);
      this.Controls.Add(this.separator1Label);
      this.Controls.Add(this.PasswordText);
      this.Controls.Add(this.passwordLabel);
      this.Controls.Add(this.UserNameText);
      this.Controls.Add(this.userNameLabel);
      this.Controls.Add(this.ApiKeyText);
      this.Controls.Add(this.apiKeyLabel);
      this.Controls.Add(this.SecureUrlText);
      this.Controls.Add(this.secureUrlLabel);
      this.Controls.Add(this.UrlText);
      this.Controls.Add(this.urlLabel);
      this.Name = "AuthPanel";
      this.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
      this.Size = new System.Drawing.Size(300, 340);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label separator1Label;
    private System.Windows.Forms.Label passwordLabel;
    private System.Windows.Forms.Label userNameLabel;
    private System.Windows.Forms.Label apiKeyLabel;
    private System.Windows.Forms.Label secureUrlLabel;
    private System.Windows.Forms.Label urlLabel;
    internal System.Windows.Forms.Button ConnectButton;
    internal System.Windows.Forms.TextBox PasswordText;
    internal System.Windows.Forms.TextBox UserNameText;
    internal System.Windows.Forms.TextBox ApiKeyText;
    internal System.Windows.Forms.TextBox SecureUrlText;
    internal System.Windows.Forms.TextBox UrlText;
  }
}
