namespace SteamAccountManager {
    partial class InputSteamGridApi {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputSteamGridApi));
            this.theme = new NSTheme();
            this.okayBtn = new NSButtonGreen();
            this.closeBtn = new NSButtonRed();
            this.apiKey = new NSTextBox();
            this.theme.SuspendLayout();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.AccentOffset = -700;
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.theme.Colors = new Bloom[0];
            this.theme.Controls.Add(this.apiKey);
            this.theme.Controls.Add(this.okayBtn);
            this.theme.Controls.Add(this.closeBtn);
            this.theme.Customization = "";
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.theme.Image = null;
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Movable = true;
            this.theme.Name = "theme";
            this.theme.NoRounding = false;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(364, 88);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Add Steam Grid Database API Key";
            this.theme.TransparencyKey = System.Drawing.Color.Empty;
            this.theme.Transparent = false;
            // 
            // okayBtn
            // 
            this.okayBtn.Location = new System.Drawing.Point(143, 60);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(75, 23);
            this.okayBtn.TabIndex = 3;
            this.okayBtn.Text = "Okay";
            this.okayBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(339, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // apiKey
            // 
            this.apiKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apiKey.Location = new System.Drawing.Point(3, 31);
            this.apiKey.MaxLength = 32767;
            this.apiKey.Multiline = false;
            this.apiKey.Name = "apiKey";
            this.apiKey.ReadOnly = false;
            this.apiKey.Size = new System.Drawing.Size(358, 23);
            this.apiKey.TabIndex = 4;
            this.apiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apiKey.UseSystemPasswordChar = false;
            // 
            // InputSteamGridApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 88);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputSteamGridApi";
            this.Text = "Add account";
            this.theme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSButtonRed closeBtn;
        private NSButtonGreen okayBtn;
        private NSTheme theme;
        private NSTextBox apiKey;
    }
}