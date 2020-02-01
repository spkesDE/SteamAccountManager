namespace SteamAccountManager {
    partial class SetupWizard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWizard));
            this.theme = new NSTheme();
            this.nsTabControl1 = new NSTabControl();
            this.welcomePage = new System.Windows.Forms.TabPage();
            this.encryptionPage = new System.Windows.Forms.TabPage();
            this.Steam = new System.Windows.Forms.TabPage();
            this.steamGridApi = new System.Windows.Forms.TabPage();
            this.addAccount = new System.Windows.Forms.TabPage();
            this.miscPage = new System.Windows.Forms.TabPage();
            this.closeBtn = new NSButton();
            this.nsLabel1 = new NSLabel();
            this.welcomeGroupBox = new NSGroupBox();
            this.nextBtn_welcome = new NSButtonGreen();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nsGroupBox1 = new NSGroupBox();
            this.nsLabel2 = new NSLabel();
            this.nsButtonGreen1 = new NSButtonGreen();
            this.nsTextBox1 = new NSTextBox();
            this.nsTextBox2 = new NSTextBox();
            this.nsLabel3 = new NSLabel();
            this.nsGroupBox2 = new NSGroupBox();
            this.nsButtonAqua2 = new NSButtonAqua();
            this.nsTextBox4 = new NSTextBox();
            this.nsButtonGreen2 = new NSButtonGreen();
            this.nsLabel4 = new NSLabel();
            this.nsGroupBox3 = new NSGroupBox();
            this.nsTextBox8 = new NSTextBox();
            this.nsButtonGreen3 = new NSButtonGreen();
            this.nsLabel5 = new NSLabel();
            this.nsGroupBox4 = new NSGroupBox();
            this.nsButtonGreen4 = new NSButtonGreen();
            this.nsLabel6 = new NSLabel();
            this.nsGroupBox5 = new NSGroupBox();
            this.nsButtonGreen5 = new NSButtonGreen();
            this.nsButtonAqua1 = new NSButtonAqua();
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
            this.label5 = new System.Windows.Forms.Label();
            this.accName = new NSTextBox();
            this.nsCheckBox1 = new NSCheckBox();
            this.nsCheckBox2 = new NSCheckBox();
            this.nsCheckBox3 = new NSCheckBox();
            this.nsCheckBox4 = new NSCheckBox();
            this.nsCheckBox5 = new NSCheckBox();
            this.theme.SuspendLayout();
            this.nsTabControl1.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.encryptionPage.SuspendLayout();
            this.Steam.SuspendLayout();
            this.steamGridApi.SuspendLayout();
            this.addAccount.SuspendLayout();
            this.miscPage.SuspendLayout();
            this.welcomeGroupBox.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            this.nsGroupBox2.SuspendLayout();
            this.nsGroupBox3.SuspendLayout();
            this.nsGroupBox4.SuspendLayout();
            this.nsGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.AccentOffset = -750;
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.theme.Colors = new Bloom[0];
            this.theme.Controls.Add(this.nsTabControl1);
            this.theme.Controls.Add(this.closeBtn);
            this.theme.Customization = "";
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.theme.Image = null;
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Movable = false;
            this.theme.Name = "theme";
            this.theme.NoRounding = false;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(647, 316);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Setup Wizard";
            this.theme.TransparencyKey = System.Drawing.Color.Empty;
            this.theme.Transparent = false;
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Controls.Add(this.welcomePage);
            this.nsTabControl1.Controls.Add(this.encryptionPage);
            this.nsTabControl1.Controls.Add(this.Steam);
            this.nsTabControl1.Controls.Add(this.steamGridApi);
            this.nsTabControl1.Controls.Add(this.addAccount);
            this.nsTabControl1.Controls.Add(this.miscPage);
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 115);
            this.nsTabControl1.Location = new System.Drawing.Point(3, 32);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(644, 281);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 1;
            // 
            // welcomePage
            // 
            this.welcomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.welcomePage.Controls.Add(this.welcomeGroupBox);
            this.welcomePage.Controls.Add(this.nsLabel1);
            this.welcomePage.Location = new System.Drawing.Point(119, 4);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomePage.Size = new System.Drawing.Size(521, 273);
            this.welcomePage.TabIndex = 0;
            this.welcomePage.Text = "Welcome";
            // 
            // encryptionPage
            // 
            this.encryptionPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.encryptionPage.Controls.Add(this.nsLabel2);
            this.encryptionPage.Controls.Add(this.nsGroupBox1);
            this.encryptionPage.Location = new System.Drawing.Point(119, 4);
            this.encryptionPage.Name = "encryptionPage";
            this.encryptionPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionPage.Size = new System.Drawing.Size(521, 273);
            this.encryptionPage.TabIndex = 1;
            this.encryptionPage.Text = "Encryption";
            // 
            // Steam
            // 
            this.Steam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Steam.Controls.Add(this.nsLabel3);
            this.Steam.Controls.Add(this.nsGroupBox2);
            this.Steam.Location = new System.Drawing.Point(119, 4);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(521, 273);
            this.Steam.TabIndex = 2;
            this.Steam.Text = "Steam";
            // 
            // steamGridApi
            // 
            this.steamGridApi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.steamGridApi.Controls.Add(this.nsLabel4);
            this.steamGridApi.Controls.Add(this.nsGroupBox3);
            this.steamGridApi.Location = new System.Drawing.Point(119, 4);
            this.steamGridApi.Name = "steamGridApi";
            this.steamGridApi.Size = new System.Drawing.Size(521, 273);
            this.steamGridApi.TabIndex = 3;
            this.steamGridApi.Text = "Steam Grid";
            // 
            // addAccount
            // 
            this.addAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addAccount.Controls.Add(this.nsLabel5);
            this.addAccount.Controls.Add(this.nsGroupBox4);
            this.addAccount.Location = new System.Drawing.Point(119, 4);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(521, 273);
            this.addAccount.TabIndex = 4;
            this.addAccount.Text = "Add account";
            // 
            // miscPage
            // 
            this.miscPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.miscPage.Controls.Add(this.nsLabel6);
            this.miscPage.Controls.Add(this.nsGroupBox5);
            this.miscPage.Location = new System.Drawing.Point(119, 4);
            this.miscPage.Name = "miscPage";
            this.miscPage.Size = new System.Drawing.Size(521, 273);
            this.miscPage.TabIndex = 5;
            this.miscPage.Text = "Miscellaneous";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(621, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(6, 6);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(510, 23);
            this.nsLabel1.TabIndex = 0;
            this.nsLabel1.Text = "title";
            this.nsLabel1.Value1 = "STEAM ACCOUNT MANAGER • ";
            this.nsLabel1.Value2 = " WELCOME";
            // 
            // welcomeGroupBox
            // 
            this.welcomeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeGroupBox.Controls.Add(this.nextBtn_welcome);
            this.welcomeGroupBox.Controls.Add(this.linkLabel1);
            this.welcomeGroupBox.Controls.Add(this.label1);
            this.welcomeGroupBox.DrawSeperator = true;
            this.welcomeGroupBox.Location = new System.Drawing.Point(6, 35);
            this.welcomeGroupBox.Name = "welcomeGroupBox";
            this.welcomeGroupBox.Size = new System.Drawing.Size(513, 235);
            this.welcomeGroupBox.SubTitle = "Welcome to the Steam Account Manager. This tool should help you to manage multipl" +
    "e Steam Accounts";
            this.welcomeGroupBox.TabIndex = 1;
            this.welcomeGroupBox.Text = "welcomeGroupBox";
            this.welcomeGroupBox.Title = "";
            // 
            // nextBtn_welcome
            // 
            this.nextBtn_welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn_welcome.Location = new System.Drawing.Point(435, 208);
            this.nextBtn_welcome.Name = "nextBtn_welcome";
            this.nextBtn_welcome.Size = new System.Drawing.Size(75, 23);
            this.nextBtn_welcome.TabIndex = 0;
            this.nextBtn_welcome.Text = "Next";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 182);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(176, 81);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(303, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/spkesDE/SteamAccountManager";
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.nsTextBox2);
            this.nsGroupBox1.Controls.Add(this.nsTextBox1);
            this.nsGroupBox1.Controls.Add(this.nsButtonGreen1);
            this.nsGroupBox1.DrawSeperator = true;
            this.nsGroupBox1.Location = new System.Drawing.Point(6, 34);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(513, 235);
            this.nsGroupBox1.SubTitle = "Please enter a password for the encryption. If no password is entered, encryption" +
    " will be disabled.";
            this.nsGroupBox1.TabIndex = 0;
            this.nsGroupBox1.Text = "nsGroupBox1";
            this.nsGroupBox1.Title = "";
            this.nsGroupBox1.Click += new System.EventHandler(this.nsGroupBox1_Click);
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel2.Location = new System.Drawing.Point(6, 6);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(510, 23);
            this.nsLabel2.TabIndex = 1;
            this.nsLabel2.Text = "title";
            this.nsLabel2.Value1 = "STEAM ACCOUNT MANAGER • ";
            this.nsLabel2.Value2 = " ENCRYPTION";
            // 
            // nsButtonGreen1
            // 
            this.nsButtonGreen1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nsButtonGreen1.Location = new System.Drawing.Point(435, 208);
            this.nsButtonGreen1.Name = "nsButtonGreen1";
            this.nsButtonGreen1.Size = new System.Drawing.Size(75, 23);
            this.nsButtonGreen1.TabIndex = 1;
            this.nsButtonGreen1.Text = "Next";
            // 
            // nsTextBox1
            // 
            this.nsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox1.Location = new System.Drawing.Point(14, 73);
            this.nsTextBox1.MaxLength = 32767;
            this.nsTextBox1.Multiline = false;
            this.nsTextBox1.Name = "nsTextBox1";
            this.nsTextBox1.ReadOnly = false;
            this.nsTextBox1.Size = new System.Drawing.Size(196, 23);
            this.nsTextBox1.TabIndex = 2;
            this.nsTextBox1.Text = "nsTextBox1";
            this.nsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox1.UseSystemPasswordChar = false;
            this.nsTextBox1.TextChanged += new System.EventHandler(this.nsTextBox1_TextChanged);
            // 
            // nsTextBox2
            // 
            this.nsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox2.Location = new System.Drawing.Point(14, 44);
            this.nsTextBox2.MaxLength = 32767;
            this.nsTextBox2.Multiline = false;
            this.nsTextBox2.Name = "nsTextBox2";
            this.nsTextBox2.ReadOnly = false;
            this.nsTextBox2.Size = new System.Drawing.Size(196, 23);
            this.nsTextBox2.TabIndex = 3;
            this.nsTextBox2.Text = "nsTextBox2";
            this.nsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox2.UseSystemPasswordChar = false;
            this.nsTextBox2.TextChanged += new System.EventHandler(this.nsTextBox2_TextChanged);
            // 
            // nsLabel3
            // 
            this.nsLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel3.Location = new System.Drawing.Point(6, 6);
            this.nsLabel3.Name = "nsLabel3";
            this.nsLabel3.Size = new System.Drawing.Size(510, 23);
            this.nsLabel3.TabIndex = 3;
            this.nsLabel3.Text = "title";
            this.nsLabel3.Value1 = "STEAM ACCOUNT MANAGER • ";
            this.nsLabel3.Value2 = " ENCRYPTION";
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.nsButtonAqua2);
            this.nsGroupBox2.Controls.Add(this.nsTextBox4);
            this.nsGroupBox2.Controls.Add(this.nsButtonGreen2);
            this.nsGroupBox2.DrawSeperator = true;
            this.nsGroupBox2.Location = new System.Drawing.Point(6, 34);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(513, 235);
            this.nsGroupBox2.SubTitle = "Please enter a password for the encryption. If no password is entered, encryption" +
    " will be disabled.";
            this.nsGroupBox2.TabIndex = 2;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "";
            // 
            // nsButtonAqua2
            // 
            this.nsButtonAqua2.isPlaying = false;
            this.nsButtonAqua2.Location = new System.Drawing.Point(358, 30);
            this.nsButtonAqua2.Name = "nsButtonAqua2";
            this.nsButtonAqua2.Size = new System.Drawing.Size(75, 23);
            this.nsButtonAqua2.TabIndex = 5;
            this.nsButtonAqua2.Text = "nsButtonAqua2";
            // 
            // nsTextBox4
            // 
            this.nsTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox4.Location = new System.Drawing.Point(3, 30);
            this.nsTextBox4.MaxLength = 32767;
            this.nsTextBox4.Multiline = false;
            this.nsTextBox4.Name = "nsTextBox4";
            this.nsTextBox4.ReadOnly = false;
            this.nsTextBox4.Size = new System.Drawing.Size(349, 23);
            this.nsTextBox4.TabIndex = 4;
            this.nsTextBox4.Text = "nsTextBox4";
            this.nsTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox4.UseSystemPasswordChar = false;
            // 
            // nsButtonGreen2
            // 
            this.nsButtonGreen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nsButtonGreen2.Location = new System.Drawing.Point(435, 208);
            this.nsButtonGreen2.Name = "nsButtonGreen2";
            this.nsButtonGreen2.Size = new System.Drawing.Size(75, 23);
            this.nsButtonGreen2.TabIndex = 1;
            this.nsButtonGreen2.Text = "Next";
            // 
            // nsLabel4
            // 
            this.nsLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel4.Location = new System.Drawing.Point(6, 6);
            this.nsLabel4.Name = "nsLabel4";
            this.nsLabel4.Size = new System.Drawing.Size(510, 23);
            this.nsLabel4.TabIndex = 3;
            this.nsLabel4.Text = "title";
            this.nsLabel4.Value1 = "STEAM ACCOUNT MANAGER • ";
            this.nsLabel4.Value2 = " ENCRYPTION";
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.Controls.Add(this.nsButtonAqua1);
            this.nsGroupBox3.Controls.Add(this.nsTextBox8);
            this.nsGroupBox3.Controls.Add(this.nsButtonGreen3);
            this.nsGroupBox3.DrawSeperator = true;
            this.nsGroupBox3.Location = new System.Drawing.Point(6, 34);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(513, 235);
            this.nsGroupBox3.SubTitle = "Please enter a password for the encryption. If no password is entered, encryption" +
    " will be disabled.";
            this.nsGroupBox3.TabIndex = 2;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "";
            // 
            // nsTextBox8
            // 
            this.nsTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox8.Location = new System.Drawing.Point(13, 38);
            this.nsTextBox8.MaxLength = 32767;
            this.nsTextBox8.Multiline = false;
            this.nsTextBox8.Name = "nsTextBox8";
            this.nsTextBox8.ReadOnly = false;
            this.nsTextBox8.Size = new System.Drawing.Size(196, 23);
            this.nsTextBox8.TabIndex = 3;
            this.nsTextBox8.Text = "nsTextBox8";
            this.nsTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox8.UseSystemPasswordChar = false;
            // 
            // nsButtonGreen3
            // 
            this.nsButtonGreen3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nsButtonGreen3.Location = new System.Drawing.Point(435, 208);
            this.nsButtonGreen3.Name = "nsButtonGreen3";
            this.nsButtonGreen3.Size = new System.Drawing.Size(75, 23);
            this.nsButtonGreen3.TabIndex = 1;
            this.nsButtonGreen3.Text = "Next";
            // 
            // nsLabel5
            // 
            this.nsLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel5.Location = new System.Drawing.Point(6, 6);
            this.nsLabel5.Name = "nsLabel5";
            this.nsLabel5.Size = new System.Drawing.Size(510, 23);
            this.nsLabel5.TabIndex = 3;
            this.nsLabel5.Text = "title";
            this.nsLabel5.Value1 = "STEAM ACCOUNT MANAGER • ";
            this.nsLabel5.Value2 = " ENCRYPTION";
            // 
            // nsGroupBox4
            // 
            this.nsGroupBox4.Controls.Add(this.getSteamId);
            this.nsGroupBox4.Controls.Add(this.getApiKey);
            this.nsGroupBox4.Controls.Add(this.apiKeyCancel);
            this.nsGroupBox4.Controls.Add(this.steamIdCancel);
            this.nsGroupBox4.Controls.Add(this.accountPassCancel);
            this.nsGroupBox4.Controls.Add(this.accNameCancel);
            this.nsGroupBox4.Controls.Add(this.label4);
            this.nsGroupBox4.Controls.Add(this.apiKey);
            this.nsGroupBox4.Controls.Add(this.label3);
            this.nsGroupBox4.Controls.Add(this.steamId);
            this.nsGroupBox4.Controls.Add(this.label2);
            this.nsGroupBox4.Controls.Add(this.accountPass);
            this.nsGroupBox4.Controls.Add(this.label5);
            this.nsGroupBox4.Controls.Add(this.accName);
            this.nsGroupBox4.Controls.Add(this.nsButtonGreen4);
            this.nsGroupBox4.DrawSeperator = true;
            this.nsGroupBox4.Location = new System.Drawing.Point(6, 34);
            this.nsGroupBox4.Name = "nsGroupBox4";
            this.nsGroupBox4.Size = new System.Drawing.Size(513, 235);
            this.nsGroupBox4.SubTitle = "Please enter a password for the encryption. If no password is entered, encryption" +
    " will be disabled.";
            this.nsGroupBox4.TabIndex = 2;
            this.nsGroupBox4.Text = "nsGroupBox4";
            this.nsGroupBox4.Title = "";
            // 
            // nsButtonGreen4
            // 
            this.nsButtonGreen4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nsButtonGreen4.Location = new System.Drawing.Point(435, 208);
            this.nsButtonGreen4.Name = "nsButtonGreen4";
            this.nsButtonGreen4.Size = new System.Drawing.Size(75, 23);
            this.nsButtonGreen4.TabIndex = 1;
            this.nsButtonGreen4.Text = "Next";
            // 
            // nsLabel6
            // 
            this.nsLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel6.Location = new System.Drawing.Point(6, 6);
            this.nsLabel6.Name = "nsLabel6";
            this.nsLabel6.Size = new System.Drawing.Size(510, 23);
            this.nsLabel6.TabIndex = 3;
            this.nsLabel6.Text = "title";
            this.nsLabel6.Value1 = "STEAM ACCOUNT MANAGER • ";
            this.nsLabel6.Value2 = " ENCRYPTION";
            // 
            // nsGroupBox5
            // 
            this.nsGroupBox5.Controls.Add(this.nsCheckBox5);
            this.nsGroupBox5.Controls.Add(this.nsCheckBox4);
            this.nsGroupBox5.Controls.Add(this.nsCheckBox3);
            this.nsGroupBox5.Controls.Add(this.nsCheckBox2);
            this.nsGroupBox5.Controls.Add(this.nsCheckBox1);
            this.nsGroupBox5.Controls.Add(this.nsButtonGreen5);
            this.nsGroupBox5.DrawSeperator = true;
            this.nsGroupBox5.Location = new System.Drawing.Point(6, 34);
            this.nsGroupBox5.Name = "nsGroupBox5";
            this.nsGroupBox5.Size = new System.Drawing.Size(513, 235);
            this.nsGroupBox5.SubTitle = "Please enter a password for the encryption. If no password is entered, encryption" +
    " will be disabled.";
            this.nsGroupBox5.TabIndex = 2;
            this.nsGroupBox5.Text = "nsGroupBox5";
            this.nsGroupBox5.Title = "";
            // 
            // nsButtonGreen5
            // 
            this.nsButtonGreen5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nsButtonGreen5.Location = new System.Drawing.Point(435, 208);
            this.nsButtonGreen5.Name = "nsButtonGreen5";
            this.nsButtonGreen5.Size = new System.Drawing.Size(75, 23);
            this.nsButtonGreen5.TabIndex = 1;
            this.nsButtonGreen5.Text = "Next";
            // 
            // nsButtonAqua1
            // 
            this.nsButtonAqua1.isPlaying = false;
            this.nsButtonAqua1.Location = new System.Drawing.Point(215, 38);
            this.nsButtonAqua1.Name = "nsButtonAqua1";
            this.nsButtonAqua1.Size = new System.Drawing.Size(75, 23);
            this.nsButtonAqua1.TabIndex = 4;
            this.nsButtonAqua1.Text = "nsButtonAqua1";
            // 
            // getSteamId
            // 
            this.getSteamId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getSteamId.Location = new System.Drawing.Point(92, 208);
            this.getSteamId.Name = "getSteamId";
            this.getSteamId.Size = new System.Drawing.Size(108, 23);
            this.getSteamId.TabIndex = 32;
            this.getSteamId.Text = "Get SteamID64";
            // 
            // getApiKey
            // 
            this.getApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getApiKey.Location = new System.Drawing.Point(3, 208);
            this.getApiKey.Name = "getApiKey";
            this.getApiKey.Size = new System.Drawing.Size(83, 23);
            this.getApiKey.TabIndex = 31;
            this.getApiKey.Text = "Get API Key";
            // 
            // apiKeyCancel
            // 
            this.apiKeyCancel.Location = new System.Drawing.Point(336, 113);
            this.apiKeyCancel.Name = "apiKeyCancel";
            this.apiKeyCancel.Size = new System.Drawing.Size(23, 23);
            this.apiKeyCancel.TabIndex = 30;
            this.apiKeyCancel.Text = "x";
            // 
            // steamIdCancel
            // 
            this.steamIdCancel.Location = new System.Drawing.Point(336, 84);
            this.steamIdCancel.Name = "steamIdCancel";
            this.steamIdCancel.Size = new System.Drawing.Size(23, 23);
            this.steamIdCancel.TabIndex = 29;
            this.steamIdCancel.Text = "x";
            // 
            // accountPassCancel
            // 
            this.accountPassCancel.Location = new System.Drawing.Point(336, 55);
            this.accountPassCancel.Name = "accountPassCancel";
            this.accountPassCancel.Size = new System.Drawing.Size(23, 23);
            this.accountPassCancel.TabIndex = 28;
            this.accountPassCancel.Text = "x";
            // 
            // accNameCancel
            // 
            this.accNameCancel.Location = new System.Drawing.Point(336, 26);
            this.accNameCancel.Name = "accNameCancel";
            this.accNameCancel.Size = new System.Drawing.Size(23, 23);
            this.accNameCancel.TabIndex = 27;
            this.accNameCancel.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "API Key";
            // 
            // apiKey
            // 
            this.apiKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apiKey.Location = new System.Drawing.Point(98, 113);
            this.apiKey.MaxLength = 32;
            this.apiKey.Multiline = false;
            this.apiKey.Name = "apiKey";
            this.apiKey.ReadOnly = false;
            this.apiKey.Size = new System.Drawing.Size(232, 23);
            this.apiKey.TabIndex = 25;
            this.apiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apiKey.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SteamID64";
            // 
            // steamId
            // 
            this.steamId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.steamId.Location = new System.Drawing.Point(98, 84);
            this.steamId.MaxLength = 17;
            this.steamId.Multiline = false;
            this.steamId.Name = "steamId";
            this.steamId.ReadOnly = false;
            this.steamId.Size = new System.Drawing.Size(232, 23);
            this.steamId.TabIndex = 23;
            this.steamId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.steamId.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // accountPass
            // 
            this.accountPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountPass.Location = new System.Drawing.Point(98, 55);
            this.accountPass.MaxLength = 32767;
            this.accountPass.Multiline = false;
            this.accountPass.Name = "accountPass";
            this.accountPass.ReadOnly = false;
            this.accountPass.Size = new System.Drawing.Size(232, 23);
            this.accountPass.TabIndex = 21;
            this.accountPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Account Name";
            // 
            // accName
            // 
            this.accName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accName.Location = new System.Drawing.Point(98, 26);
            this.accName.MaxLength = 32767;
            this.accName.Multiline = false;
            this.accName.Name = "accName";
            this.accName.ReadOnly = false;
            this.accName.Size = new System.Drawing.Size(232, 23);
            this.accName.TabIndex = 19;
            this.accName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accName.UseSystemPasswordChar = false;
            // 
            // nsCheckBox1
            // 
            this.nsCheckBox1.Checked = false;
            this.nsCheckBox1.Location = new System.Drawing.Point(3, 27);
            this.nsCheckBox1.Name = "nsCheckBox1";
            this.nsCheckBox1.Size = new System.Drawing.Size(190, 23);
            this.nsCheckBox1.TabIndex = 2;
            this.nsCheckBox1.Text = "nsCheckBox1";
            // 
            // nsCheckBox2
            // 
            this.nsCheckBox2.Checked = false;
            this.nsCheckBox2.Location = new System.Drawing.Point(3, 56);
            this.nsCheckBox2.Name = "nsCheckBox2";
            this.nsCheckBox2.Size = new System.Drawing.Size(190, 23);
            this.nsCheckBox2.TabIndex = 3;
            this.nsCheckBox2.Text = "nsCheckBox2";
            // 
            // nsCheckBox3
            // 
            this.nsCheckBox3.Checked = false;
            this.nsCheckBox3.Location = new System.Drawing.Point(3, 85);
            this.nsCheckBox3.Name = "nsCheckBox3";
            this.nsCheckBox3.Size = new System.Drawing.Size(190, 23);
            this.nsCheckBox3.TabIndex = 4;
            this.nsCheckBox3.Text = "nsCheckBox3";
            // 
            // nsCheckBox4
            // 
            this.nsCheckBox4.Checked = false;
            this.nsCheckBox4.Location = new System.Drawing.Point(3, 114);
            this.nsCheckBox4.Name = "nsCheckBox4";
            this.nsCheckBox4.Size = new System.Drawing.Size(190, 23);
            this.nsCheckBox4.TabIndex = 5;
            this.nsCheckBox4.Text = "nsCheckBox4";
            // 
            // nsCheckBox5
            // 
            this.nsCheckBox5.Checked = false;
            this.nsCheckBox5.Location = new System.Drawing.Point(3, 143);
            this.nsCheckBox5.Name = "nsCheckBox5";
            this.nsCheckBox5.Size = new System.Drawing.Size(190, 23);
            this.nsCheckBox5.TabIndex = 6;
            this.nsCheckBox5.Text = "nsCheckBox5";
            // 
            // SetupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 316);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupWizard";
            this.Text = "Setup Wizard";
            this.TopMost = true;
            this.theme.ResumeLayout(false);
            this.nsTabControl1.ResumeLayout(false);
            this.welcomePage.ResumeLayout(false);
            this.encryptionPage.ResumeLayout(false);
            this.Steam.ResumeLayout(false);
            this.steamGridApi.ResumeLayout(false);
            this.addAccount.ResumeLayout(false);
            this.miscPage.ResumeLayout(false);
            this.welcomeGroupBox.ResumeLayout(false);
            this.welcomeGroupBox.PerformLayout();
            this.nsGroupBox1.ResumeLayout(false);
            this.nsGroupBox2.ResumeLayout(false);
            this.nsGroupBox3.ResumeLayout(false);
            this.nsGroupBox4.ResumeLayout(false);
            this.nsGroupBox4.PerformLayout();
            this.nsGroupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme theme;
        private NSButton closeBtn;
        private NSTabControl nsTabControl1;
        private System.Windows.Forms.TabPage welcomePage;
        private System.Windows.Forms.TabPage encryptionPage;
        private System.Windows.Forms.TabPage Steam;
        private System.Windows.Forms.TabPage steamGridApi;
        private System.Windows.Forms.TabPage addAccount;
        private System.Windows.Forms.TabPage miscPage;
        private NSGroupBox welcomeGroupBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private NSButtonGreen nextBtn_welcome;
        private NSLabel nsLabel1;
        private NSLabel nsLabel2;
        private NSGroupBox nsGroupBox1;
        private NSTextBox nsTextBox2;
        private NSTextBox nsTextBox1;
        private NSButtonGreen nsButtonGreen1;
        private NSLabel nsLabel3;
        private NSGroupBox nsGroupBox2;
        private NSButtonAqua nsButtonAqua2;
        private NSTextBox nsTextBox4;
        private NSButtonGreen nsButtonGreen2;
        private NSLabel nsLabel4;
        private NSGroupBox nsGroupBox3;
        private NSButtonAqua nsButtonAqua1;
        private NSTextBox nsTextBox8;
        private NSButtonGreen nsButtonGreen3;
        private NSLabel nsLabel5;
        private NSGroupBox nsGroupBox4;
        private NSButtonGreen nsButtonGreen4;
        private NSLabel nsLabel6;
        private NSGroupBox nsGroupBox5;
        private NSButtonGreen nsButtonGreen5;
        private NSButton getSteamId;
        private NSButton getApiKey;
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
        private System.Windows.Forms.Label label5;
        private NSTextBox accName;
        private NSCheckBox nsCheckBox5;
        private NSCheckBox nsCheckBox4;
        private NSCheckBox nsCheckBox3;
        private NSCheckBox nsCheckBox2;
        private NSCheckBox nsCheckBox1;
    }
}