namespace SteamAccountManager
{
    partial class AddAccountWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountWindow));
            this.theme = new NSTheme();
            this.getSteamId = new NSButton();
            this.getApiKey = new NSButton();
            this.apiKeyCancel = new NSButton();
            this.steamIdCancel = new NSButton();
            this.accountPassCancel = new NSButton();
            this.accNameCancel = new NSButton();
            this.label4 = new System.Windows.Forms.Label();
            this.apiKey = new NSTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.steamId = new NSTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountPass = new NSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accName = new NSTextBox();
            this.cancelBtn = new NSButtonRed();
            this.addBtn = new NSButtonGreen();
            this.closeBtn = new NSButtonRed();
            this.theme.SuspendLayout();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.AccentOffset = -700;
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.theme.Colors = new Bloom[0];
            this.theme.Controls.Add(this.getSteamId);
            this.theme.Controls.Add(this.getApiKey);
            this.theme.Controls.Add(this.apiKeyCancel);
            this.theme.Controls.Add(this.steamIdCancel);
            this.theme.Controls.Add(this.accountPassCancel);
            this.theme.Controls.Add(this.accNameCancel);
            this.theme.Controls.Add(this.label4);
            this.theme.Controls.Add(this.apiKey);
            this.theme.Controls.Add(this.label3);
            this.theme.Controls.Add(this.steamId);
            this.theme.Controls.Add(this.label2);
            this.theme.Controls.Add(this.accountPass);
            this.theme.Controls.Add(this.label1);
            this.theme.Controls.Add(this.accName);
            this.theme.Controls.Add(this.cancelBtn);
            this.theme.Controls.Add(this.addBtn);
            this.theme.Controls.Add(this.closeBtn);
            this.theme.Customization = "";
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.theme.Image = null;
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Movable = true;
            this.theme.Name = "theme";
            this.theme.NoRounding = true;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(364, 173);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Add account";
            this.theme.TransparencyKey = System.Drawing.Color.Empty;
            this.theme.Transparent = false;
            // 
            // getSteamId
            // 
            this.getSteamId.Location = new System.Drawing.Point(92, 147);
            this.getSteamId.Name = "getSteamId";
            this.getSteamId.Size = new System.Drawing.Size(108, 23);
            this.getSteamId.TabIndex = 18;
            this.getSteamId.Text = "Get SteamID64";
            this.getSteamId.Click += new System.EventHandler(this.getSteamId_Click);
            // 
            // getApiKey
            // 
            this.getApiKey.Location = new System.Drawing.Point(3, 147);
            this.getApiKey.Name = "getApiKey";
            this.getApiKey.Size = new System.Drawing.Size(83, 23);
            this.getApiKey.TabIndex = 17;
            this.getApiKey.Text = "Get API Key";
            this.getApiKey.Click += new System.EventHandler(this.getApiKey_Click);
            // 
            // apiKeyCancel
            // 
            this.apiKeyCancel.Location = new System.Drawing.Point(339, 118);
            this.apiKeyCancel.Name = "apiKeyCancel";
            this.apiKeyCancel.Size = new System.Drawing.Size(23, 23);
            this.apiKeyCancel.TabIndex = 16;
            this.apiKeyCancel.Text = "x";
            this.apiKeyCancel.Click += new System.EventHandler(this.apiKeyCancel_Click);
            // 
            // steamIdCancel
            // 
            this.steamIdCancel.Location = new System.Drawing.Point(339, 89);
            this.steamIdCancel.Name = "steamIdCancel";
            this.steamIdCancel.Size = new System.Drawing.Size(23, 23);
            this.steamIdCancel.TabIndex = 15;
            this.steamIdCancel.Text = "x";
            this.steamIdCancel.Click += new System.EventHandler(this.steamIdCancel_Click);
            // 
            // accountPassCancel
            // 
            this.accountPassCancel.Location = new System.Drawing.Point(339, 60);
            this.accountPassCancel.Name = "accountPassCancel";
            this.accountPassCancel.Size = new System.Drawing.Size(23, 23);
            this.accountPassCancel.TabIndex = 14;
            this.accountPassCancel.Text = "x";
            this.accountPassCancel.Click += new System.EventHandler(this.accountPassCancel_Click);
            // 
            // accNameCancel
            // 
            this.accNameCancel.Location = new System.Drawing.Point(339, 31);
            this.accNameCancel.Name = "accNameCancel";
            this.accNameCancel.Size = new System.Drawing.Size(23, 23);
            this.accNameCancel.TabIndex = 13;
            this.accNameCancel.Text = "x";
            this.accNameCancel.Click += new System.EventHandler(this.accNameCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "API Key";
            // 
            // apiKey
            // 
            this.apiKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apiKey.Location = new System.Drawing.Point(101, 118);
            this.apiKey.MaxLength = 32;
            this.apiKey.Multiline = false;
            this.apiKey.Name = "apiKey";
            this.apiKey.ReadOnly = false;
            this.apiKey.Size = new System.Drawing.Size(232, 23);
            this.apiKey.TabIndex = 11;
            this.apiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apiKey.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SteamID64";
            // 
            // steamId
            // 
            this.steamId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.steamId.Location = new System.Drawing.Point(101, 89);
            this.steamId.MaxLength = 17;
            this.steamId.Multiline = false;
            this.steamId.Name = "steamId";
            this.steamId.ReadOnly = false;
            this.steamId.Size = new System.Drawing.Size(232, 23);
            this.steamId.TabIndex = 9;
            this.steamId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.steamId.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // accountPass
            // 
            this.accountPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountPass.Location = new System.Drawing.Point(101, 60);
            this.accountPass.MaxLength = 32767;
            this.accountPass.Multiline = false;
            this.accountPass.Name = "accountPass";
            this.accountPass.ReadOnly = false;
            this.accountPass.Size = new System.Drawing.Size(232, 23);
            this.accountPass.TabIndex = 7;
            this.accountPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Name";
            // 
            // accName
            // 
            this.accName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accName.Location = new System.Drawing.Point(101, 31);
            this.accName.MaxLength = 32767;
            this.accName.Multiline = false;
            this.accName.Name = "accName";
            this.accName.ReadOnly = false;
            this.accName.Size = new System.Drawing.Size(232, 23);
            this.accName.TabIndex = 5;
            this.accName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accName.UseSystemPasswordChar = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(206, 147);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(287, 147);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(339, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 173);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAccountWindow";
            this.Text = "Add account";
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme theme;
        private NSButtonRed closeBtn;
        private NSButton apiKeyCancel;
        private NSButton steamIdCancel;
        private NSButton accountPassCancel;
        private NSButton accNameCancel;
        private System.Windows.Forms.Label label4;
        private NSTextBox apiKey;
        private System.Windows.Forms.Label label3;
        private NSTextBox steamId;
        private System.Windows.Forms.Label label2;
        private NSTextBox accountPass;
        private System.Windows.Forms.Label label1;
        private NSTextBox accName;
        private NSButtonRed cancelBtn;
        private NSButtonGreen addBtn;
        private NSButton getSteamId;
        private NSButton getApiKey;
    }
}