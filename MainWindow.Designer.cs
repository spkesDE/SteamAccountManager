using System;

namespace SteamAccountManager {
    partial class MainWindow {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelCover = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.theme = new NSTheme();
            this.minimizeBtn = new NSButton();
            this.searchBtn = new NSButtonRed();
            this.totalGames = new System.Windows.Forms.Label();
            this.searchBox = new NSTextBox();
            this.flowPanel = new CustomFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenu = new NSContextMenu();
            this.accountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCoverFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamGridDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSlowAsyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setAPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GridTipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeOnLauchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTrayOnCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectSteamExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPlaceholderCoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rip2 = new System.Windows.Forms.Label();
            this.ripPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gameName2 = new System.Windows.Forms.Label();
            this.closeBtn = new NSButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContext = new NSContextMenu();
            this.openPoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lauchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theme.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.trayContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCover
            // 
            this.panelCover.Location = new System.Drawing.Point(209, 3);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(200, 100);
            this.panelCover.TabIndex = 1;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 50;
            this.toolTip.AutoPopDelay = 2500;
            this.toolTip.InitialDelay = 50;
            this.toolTip.ReshowDelay = 10;
            // 
            // theme
            // 
            this.theme.AccentOffset = -1000;
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.theme.Colors = new Bloom[0];
            this.theme.Controls.Add(this.minimizeBtn);
            this.theme.Controls.Add(this.searchBtn);
            this.theme.Controls.Add(this.totalGames);
            this.theme.Controls.Add(this.searchBox);
            this.theme.Controls.Add(this.flowPanel);
            this.theme.Controls.Add(this.closeBtn);
            this.theme.Customization = "";
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.theme.Image = null;
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.MinimumSize = new System.Drawing.Size(625, 350);
            this.theme.Movable = true;
            this.theme.Name = "theme";
            this.theme.NoRounding = true;
            this.theme.Sizable = true;
            this.theme.Size = new System.Drawing.Size(1242, 776);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Steam Account Manager";
            this.theme.TransparencyKey = System.Drawing.Color.Empty;
            this.theme.Transparent = false;
            this.theme.Resize += new System.EventHandler(this.theme_Resize);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Location = new System.Drawing.Point(1193, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(23, 23);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(1132, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(60, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "search...";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // totalGames
            // 
            this.totalGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalGames.ForeColor = System.Drawing.Color.White;
            this.totalGames.Location = new System.Drawing.Point(789, 7);
            this.totalGames.Name = "totalGames";
            this.totalGames.Size = new System.Drawing.Size(143, 13);
            this.totalGames.TabIndex = 3;
            this.totalGames.Text = "You have ?? games.";
            this.totalGames.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Location = new System.Drawing.Point(937, 2);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.ReadOnly = false;
            this.searchBox.Size = new System.Drawing.Size(194, 23);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.UseSystemPasswordChar = false;
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowPanel.Controls.Add(this.panel1);
            this.flowPanel.Location = new System.Drawing.Point(3, 33);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1256, 740);
            this.flowPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenu;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rip2);
            this.panel1.Controls.Add(this.ripPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // contextMenu
            // 
            this.contextMenu.ForeColor = System.Drawing.Color.White;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lauchToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.accountMenuItem,
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 136);
            // 
            // accountMenuItem
            // 
            this.accountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator5});
            this.accountMenuItem.Name = "accountMenuItem";
            this.accountMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountMenuItem.Text = "Account";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.addToolStripMenuItem.Text = "+add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(99, 6);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bannedMenuItem,
            this.openCoverFolderToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // bannedMenuItem
            // 
            this.bannedMenuItem.ForeColor = System.Drawing.Color.White;
            this.bannedMenuItem.Name = "bannedMenuItem";
            this.bannedMenuItem.ShowShortcutKeys = false;
            this.bannedMenuItem.Size = new System.Drawing.Size(169, 22);
            this.bannedMenuItem.Text = "Banned";
            this.bannedMenuItem.Click += new System.EventHandler(this.vACedToolStripMenuItem_Click);
            // 
            // openCoverFolderToolStripMenuItem
            // 
            this.openCoverFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openCoverFolderToolStripMenuItem.Name = "openCoverFolderToolStripMenuItem";
            this.openCoverFolderToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openCoverFolderToolStripMenuItem.Text = "Open cover folder";
            this.openCoverFolderToolStripMenuItem.Click += new System.EventHandler(this.openCoverFolderToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamGridDBToolStripMenuItem,
            this.toolStripSeparator3,
            this.minimizeOnLauchToolStripMenuItem,
            this.loginOnlyToolStripMenuItem,
            this.toTrayOnCloseToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectSteamExToolStripMenuItem,
            this.selectPlaceholderCoverToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // steamGridDBToolStripMenuItem
            // 
            this.steamGridDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableSlowAsyncToolStripMenuItem,
            this.toolStripSeparator2,
            this.setAPIKeyToolStripMenuItem,
            this.getAPIKeyToolStripMenuItem,
            this.toolStripSeparator1,
            this.GridTipMenuItem});
            this.steamGridDBToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.steamGridDBToolStripMenuItem.Name = "steamGridDBToolStripMenuItem";
            this.steamGridDBToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.steamGridDBToolStripMenuItem.Text = "SteamGridDB";
            // 
            // enableSlowAsyncToolStripMenuItem
            // 
            this.enableSlowAsyncToolStripMenuItem.Enabled = false;
            this.enableSlowAsyncToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.enableSlowAsyncToolStripMenuItem.Name = "enableSlowAsyncToolStripMenuItem";
            this.enableSlowAsyncToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.enableSlowAsyncToolStripMenuItem.Text = "Enable (Slow / Async)";
            this.enableSlowAsyncToolStripMenuItem.Click += new System.EventHandler(this.enableSlowAsyncToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // setAPIKeyToolStripMenuItem
            // 
            this.setAPIKeyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.setAPIKeyToolStripMenuItem.Name = "setAPIKeyToolStripMenuItem";
            this.setAPIKeyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.setAPIKeyToolStripMenuItem.Text = "Set API Key";
            this.setAPIKeyToolStripMenuItem.Click += new System.EventHandler(this.setAPIKeyToolStripMenuItem_Click);
            // 
            // getAPIKeyToolStripMenuItem
            // 
            this.getAPIKeyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.getAPIKeyToolStripMenuItem.Name = "getAPIKeyToolStripMenuItem";
            this.getAPIKeyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.getAPIKeyToolStripMenuItem.Text = "Get API Key";
            this.getAPIKeyToolStripMenuItem.Click += new System.EventHandler(this.getAPIKeyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // GridTipMenuItem
            // 
            this.GridTipMenuItem.Enabled = false;
            this.GridTipMenuItem.ForeColor = System.Drawing.Color.White;
            this.GridTipMenuItem.Name = "GridTipMenuItem";
            this.GridTipMenuItem.Size = new System.Drawing.Size(207, 22);
            this.GridTipMenuItem.Text = "To enable set API key first";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(252, 6);
            // 
            // minimizeOnLauchToolStripMenuItem
            // 
            this.minimizeOnLauchToolStripMenuItem.Checked = true;
            this.minimizeOnLauchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeOnLauchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minimizeOnLauchToolStripMenuItem.Name = "minimizeOnLauchToolStripMenuItem";
            this.minimizeOnLauchToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.minimizeOnLauchToolStripMenuItem.Text = "Minimize on lauch";
            this.minimizeOnLauchToolStripMenuItem.Click += new System.EventHandler(this.minimizeOnLauchToolStripMenuItem_Click);
            // 
            // loginOnlyToolStripMenuItem
            // 
            this.loginOnlyToolStripMenuItem.Checked = true;
            this.loginOnlyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loginOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginOnlyToolStripMenuItem.Name = "loginOnlyToolStripMenuItem";
            this.loginOnlyToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.loginOnlyToolStripMenuItem.Text = "Login only";
            this.loginOnlyToolStripMenuItem.Click += new System.EventHandler(this.loginOnlyToolStripMenuItem_Click);
            // 
            // toTrayOnCloseToolStripMenuItem
            // 
            this.toTrayOnCloseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toTrayOnCloseToolStripMenuItem.Name = "toTrayOnCloseToolStripMenuItem";
            this.toTrayOnCloseToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.toTrayOnCloseToolStripMenuItem.Text = "To tray on close";
            this.toTrayOnCloseToolStripMenuItem.Click += new System.EventHandler(this.toTrayOnCloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(252, 6);
            // 
            // selectSteamExToolStripMenuItem
            // 
            this.selectSteamExToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectSteamExToolStripMenuItem.Name = "selectSteamExToolStripMenuItem";
            this.selectSteamExToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.selectSteamExToolStripMenuItem.Text = "Select steam executable";
            this.selectSteamExToolStripMenuItem.Click += new System.EventHandler(this.selectSteamExToolStripMenuItem_Click);
            // 
            // selectPlaceholderCoverToolStripMenuItem
            // 
            this.selectPlaceholderCoverToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectPlaceholderCoverToolStripMenuItem.Name = "selectPlaceholderCoverToolStripMenuItem";
            this.selectPlaceholderCoverToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.selectPlaceholderCoverToolStripMenuItem.Text = "Select placeholder cover (200x300)";
            this.selectPlaceholderCoverToolStripMenuItem.Click += new System.EventHandler(this.selectPlaceholderCoverToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Squad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rip2
            // 
            this.rip2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rip2.AutoSize = true;
            this.rip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rip2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rip2.Location = new System.Drawing.Point(0, 71);
            this.rip2.Margin = new System.Windows.Forms.Padding(0);
            this.rip2.Name = "rip2";
            this.rip2.Padding = new System.Windows.Forms.Padding(3);
            this.rip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rip2.Size = new System.Drawing.Size(45, 19);
            this.rip2.TabIndex = 0;
            this.rip2.Text = "R.I.P.";
            this.rip2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ripPanel
            // 
            this.ripPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ripPanel.AutoSize = true;
            this.ripPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ripPanel.Location = new System.Drawing.Point(200, 52);
            this.ripPanel.Name = "ripPanel";
            this.ripPanel.Size = new System.Drawing.Size(0, 0);
            this.ripPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.gameName2);
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 25);
            this.panel2.TabIndex = 1;
            // 
            // gameName2
            // 
            this.gameName2.Location = new System.Drawing.Point(6, 6);
            this.gameName2.Name = "gameName2";
            this.gameName2.Size = new System.Drawing.Size(191, 13);
            this.gameName2.TabIndex = 1;
            this.gameName2.Text = "Squad";
            this.gameName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(1217, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayContext;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Steam Account Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // trayContext
            // 
            this.trayContext.ForeColor = System.Drawing.Color.White;
            this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPoolStripMenuItem,
            this.closeToolStripMenuItem});
            this.trayContext.Name = "nsContextMenu1";
            this.trayContext.Size = new System.Drawing.Size(104, 48);
            // 
            // openPoolStripMenuItem
            // 
            this.openPoolStripMenuItem.Name = "openPoolStripMenuItem";
            this.openPoolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openPoolStripMenuItem.Text = "Open";
            this.openPoolStripMenuItem.Click += new System.EventHandler(this.openPoolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lauchToolStripMenuItem
            // 
            this.lauchToolStripMenuItem.Name = "lauchToolStripMenuItem";
            this.lauchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lauchToolStripMenuItem.Text = "Lauch";
            this.lauchToolStripMenuItem.Click += new System.EventHandler(this.lauchToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 776);
            this.Controls.Add(this.theme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(625, 350);
            this.Name = "MainWindow";
            this.Text = "Steam Account Manager";
            this.theme.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.trayContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme theme;
        private NSButton closeBtn;
        private CustomFlowLayoutPanel flowPanel;
        private NSContextMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem accountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannedMenuItem;
        private NSTextBox searchBox;
        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.Label totalGames;
        private NSButtonRed searchBtn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeOnLauchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSteamExToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPlaceholderCoverToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ripPanel;
        private System.Windows.Forms.Label rip2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gameName2;
        private NSButton minimizeBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toTrayOnCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem steamGridDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSlowAsyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem setAPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem GridTipMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem openCoverFolderToolStripMenuItem;
        private NSContextMenu trayContext;
        private System.Windows.Forms.ToolStripMenuItem openPoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem lauchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}
