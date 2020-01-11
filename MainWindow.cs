using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager {
    public partial class MainWindow : Form {
        Dictionary<Panel, Game> panelGame = new Dictionary<Panel, Game>();
        Dictionary<Panel, Account> panelAccount = new Dictionary<Panel, Account>();

        List<Account> accounts = new List<Account>();
        Panel lastHovedPanel;
        Config config;
        int _totalGames = 0;
        public MainWindow() {
            InitializeComponent();
            Directory.CreateDirectory(Application.StartupPath + "/data");
            if(File.Exists(Application.StartupPath + "/data/config.json")) {
                this.config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Application.StartupPath + "/data/config.json"));
                loginOnlyToolStripMenuItem.Checked = config.onlyLogin;
                minimizeOnLauchToolStripMenuItem.Checked = config.minimize;
                toTrayOnCloseToolStripMenuItem.Checked = config.toTrayOnClose;
                if(config.useSteamGridDBKey != null) {
                    enableSlowAsyncToolStripMenuItem.Checked = config.useSteamGridDB;
                    enableSlowAsyncToolStripMenuItem.Enabled = true;
                    GridTipMenuItem.Text = config.useSteamGridDBKey;
                }
            } else {
                this.config = new Config();
                File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
            }

            string[] accountFolder = Directory.GetDirectories(Application.StartupPath + "/data");
            foreach(var item in accountFolder) {
                if(!File.Exists(item + "/accountData.json"))
                    continue;
                Account acc = JsonConvert.DeserializeObject<Account>(File.ReadAllText(item + "/accountData.json"));
                accounts.Add(acc);

                using(WebClient wc = new WebClient()) {
                    try {
                        var json = wc.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + acc.key + "&steamid=" + acc.steamId + "&include_appinfo=1");
                        JObject getOwnedGames = JObject.Parse(json);
                        IList<JToken> response = getOwnedGames["response"]["games"].Children().ToList();
                        foreach(JToken result in response) {
                            Game g = result.ToObject<Game>();
                            if(File.Exists(Application.StartupPath + "/data/" + acc.accountName + "/" + g.appid + "/gameData.json")) {
                                g = JsonConvert.DeserializeObject<Game>(File.ReadAllText(Application.StartupPath + "/data/" + acc.accountName + "/" + g.appid + "/gameData.json"));
                            } else {
                                Directory.CreateDirectory(Application.StartupPath + "/data/" + acc.accountName + "/" + g.appid);
                                File.WriteAllText(Application.StartupPath + "/data/" + acc.accountName + "/" + g.appid + "/gameData.json", JsonConvert.SerializeObject(g));
                            }
                            g.accountName = acc.accountName;
                            acc.addGame(g);
                            createPanel(g, acc);
                        }
                        Debug.WriteLine(acc.accountName + " loaded by API.");
                    } catch {
                        string[] games = Directory.GetDirectories(Application.StartupPath + "/data/" + acc.accountName + "/");

                        foreach(var gameFolder in games) {
                            if(File.Exists(gameFolder + "/gameData.json")) {
                                Game g = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFolder + "/gameData.json"));
                                g.accountName = acc.accountName;
                                acc.addGame(g);
                            } else {
                                Debug.WriteLine("No gameData.json found in " + gameFolder.ToString());
                            }
                        }
                        Debug.WriteLine(acc.accountName + " loaded by Files.");
                    }
                }
                addContextMenuItem(acc);
            }

            if(accountFolder.Length == 0) {
                Form addForm = new AddAccountWindow(this);
                addForm.Show();
                addForm.BringToFront();
                this.WindowState = FormWindowState.Minimized;
            } else {
                this.Select();
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, 
            int nTopRect, 
            int nRightRect,    
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Panel createPanel(Game g, Account acc) {
            if(g == null)
                return null;
            if(acc == null)
                return null;
            #region Panels
            Panel panel = new Panel();
            flowPanel.Controls.Add(panel);
            panel.Location = new Point(3, 3);
            panel.Name = "panel1";
            panel.Size = new Size(200, 300);
            panel.MouseEnter += new EventHandler(onMouseEnter);
            panel.MouseLeave += new EventHandler(onMouseLeave);
            panel.ContextMenuStrip = this.contextMenu;
            //panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 15, 15));
            panel.DoubleClick += new EventHandler(this.onGameDoubleClick);
            g.mainPanel = panel;

            /*Panel bottomPanel = new Panel();
            panel.Controls.Add(bottomPanel);
            bottomPanel.BackColor = Color.FromArgb(100, 100, 100, 100);
            bottomPanel.Location = new Point(0, 275);
            bottomPanel.Size = new Size(200, 25);
            g.bottomPanel = bottomPanel;*/


            Label gameName = new Label();
            panel.Controls.Add(gameName);
            gameName.Location = new Point(0, 275);
            gameName.Name = g.name;
            gameName.BackColor = Color.FromArgb(100, 100, 100, 100);
            gameName.ForeColor = Color.FromArgb(255, 255, 255, 255);
            gameName.Padding = new Padding(3);
            gameName.Size = new Size(200, 25);
            gameName.AutoSize = false;
            gameName.TextAlign = ContentAlignment.MiddleCenter;
            gameName.MouseClick += (sender, e) => gameName_ToolTip(sender, e, g);
            gameName.Text = g.name;
            g.gameName = gameName;

            /*Panel topPanel = new Panel();
            panel.Controls.Add(topPanel);
            topPanel.BackColor = Color.FromArgb(100, 100, 100, 100);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel2";
            topPanel.Size = new Size(200, 25);
            g.topPanel = topPanel;*/

            Label accountName = new Label();
            panel.Controls.Add(accountName);
            accountName.Location = new Point(0, 0);
            accountName.Name = "accountName2";
            accountName.Size = new Size(200, 25);
            accountName.Padding = new Padding(3);
            accountName.BackColor = Color.FromArgb(100, 100, 100, 100);
            accountName.ForeColor = Color.FromArgb(255, 255, 255, 255);
            accountName.TextAlign = ContentAlignment.MiddleCenter;
            accountName.Text = acc.accountName;
            g.accountLabel = accountName;
            g.accountName = acc.accountName;

            Label ripLabel = new Label();
            panel.Controls.Add(ripLabel);
            ripLabel.AutoSize = true;
            ripLabel.Location = new Point(0, 60);
            ripLabel.Padding = new Padding(3);
            ripLabel.Name = "ripLabel";
            ripLabel.Size = new Size(37, 13);
            ripLabel.BackColor = Color.FromArgb(180, 255, 0, 0);
            ripLabel.TextAlign = ContentAlignment.MiddleCenter;
            ripLabel.Text = config.bannedText;
            g.ripLabel = ripLabel;

            #endregion

            if(!g.banned)
                ripLabel.Visible = false;
            this.panelGame.Add(panel, g);
            panelAccount.Add(panel, acc);
            if(File.Exists(Application.StartupPath + "/data/" + acc.accountName + "/" + g.appid + "/cover.jpg")) {
                panel.BackgroundImage = FromFile(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid + "/cover.jpg");
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                g.hasCover = true;
            } else if(!g.usesPlaceholder) {
                downloadCovers(panel, g);
            } else {
                if(config.placeHolderCover != null && File.Exists(config.placeHolderCover)) {
                    panel.BackgroundImage = FromFile(config.placeHolderCover);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                } else {
                    panel.BackgroundImage = Properties.Resources.placeholder;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            File.WriteAllText(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid + "/gameData.json", JsonConvert.SerializeObject(g));
            this._totalGames++;
            this.totalGames.Text = "You have " + this._totalGames + " games.";
            return panel;
        }

        public void downloadCovers(Panel panel, Game g) {
            if(panel == null)
                return;
            if(g == null)
                return;
            try {
                var request = WebRequest.Create(new Uri("https://steamcdn-a.akamaihd.net/steam/apps/" + g.appid + "/library_600x900.jpg"));
                using(var imgResponse = request.GetResponse())
                using(var stream = imgResponse.GetResponseStream()) {
                    Image img = ScaleImage(Bitmap.FromStream(stream), 200, 300);
                    panel.BackgroundImage = img;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                    img.Save(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid + "/cover.jpg");
                    g.hasCover = true;
                }
            } catch {
                if(config.useSteamGridDB) {
                    try {
                        using(WebClient webClient = new WebClient()) {
                            Debug.WriteLine("[" + g.accountName + "] Downloading aSync from SteamgridDB for app " + g.appid);
                            webClient.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + config.useSteamGridDBKey);
                            var json = webClient.DownloadString("https://www.steamgriddb.com/api/v2/grids/steam/" + g.appid + "?dimensions=600x900&types=static");
                            JObject getGrids = JObject.Parse(json);
                            IList<JToken> response = getGrids["data"].Children().ToList();
                            List<SteamGridDB> grids = new List<SteamGridDB>();
                            foreach(JToken r in response) {
                                SteamGridDB steamGridDB = r.ToObject<SteamGridDB>();
                                grids.Add(steamGridDB);
                            }
                            if(grids.Count != 0) {
                                var result = GetImageAsync(new Uri(grids[0].url));
                                result.ContinueWith(task => {
                                    if(task.Result != null) {
                                        FileInfo file = new FileInfo(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid);
                                        file.Directory.Create();
                                        ScaleImage(task.Result, 200, 300).Save(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid + "/cover.jpg");
                                        //task.Result.Save(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid + "/cover.jpg");
                                        panel.BackgroundImage = task.Result;
                                        panel.BackgroundImageLayout = ImageLayout.Stretch;
                                        Debug.WriteLine("[" + g.accountName + "] Download completed for " + g.appid);
                                        g.hasCover = true;
                                    }
                                });
                            } else {
                                Debug.WriteLine("[" + g.accountName + "] No Grid found for " + g.appid);
                                g.usesPlaceholder = true;
                            }
                        }
                    } catch (WebException){
                        Debug.WriteLine("[" + g.accountName + "] AppId was not found on SteamGridDb: " + g.appid);
                        g.usesPlaceholder = true;
                    }
                }
                if(config.placeHolderCover != null && File.Exists(config.placeHolderCover)) {
                    panel.BackgroundImage = FromFile(config.placeHolderCover);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                } else {
                    panel.BackgroundImage = Properties.Resources.placeholder;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        public static async Task<Image> GetImageAsync(Uri url) {
            var tcs = new TaskCompletionSource<Image>();
            Image webImage = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                .ContinueWith(task => {
                    HttpWebResponse webResponse = null;
                    try {
                        webResponse = (HttpWebResponse)task.Result;
                    } catch { }
                    if(webResponse != null) {
                        Stream responseStream = webResponse.GetResponseStream();
                        if(webResponse.ContentEncoding.ToLower().Contains("gzip"))
                            responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                        else if(webResponse.ContentEncoding.ToLower().Contains("deflate"))
                            responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);

                        try {
                            if(responseStream != null)
                                webImage = Image.FromStream(responseStream);
                        } catch {

                        }
                        tcs.TrySetResult(webImage);
                        webResponse.Close();
                        responseStream.Close();
                    }
                });
            return tcs.Task.Result;
        }

        private void onAccountDelete(object sender, EventArgs e, Account acc) {
            foreach(Game game in acc.games) {
                game.ripLabel.Hide();
                Controls.Remove(game.ripLabel);
                game.ripLabel.Dispose();

                game.accountLabel.Hide();
                Controls.Remove(game.accountLabel);
                game.accountLabel.Dispose();

                game.gameName.Hide();
                Controls.Remove(game.gameName);
                game.gameName.Dispose();

                game.mainPanel.Hide();
                Controls.Remove(game.mainPanel);
                game.mainPanel.Dispose();
            }
            acc.contextMenuItem.Visible = false;
            accounts.Remove(acc);
            Directory.Delete(Application.StartupPath + "/data/" + acc.accountName + "/", true);
            using(Form form = new ErrorWindow("Account " + acc.accountName + " is deleted", "Done!")) {
                form.ShowDialog();
            }
        }

        internal void addAccount(string name, string pw, string id, string apikey) {
            try {
                Account acc = new Account(name, pw, id, apikey);
                using(WebClient wc = new WebClient()) {
                    var json = wc.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + apikey + "&steamid=" + id + "&include_appinfo=1");
                    JObject getOwnedGames = JObject.Parse(json);
                    IList<JToken> response = getOwnedGames["response"]["games"].Children().ToList();
                    foreach(JToken result in response) {
                        Game g = result.ToObject<Game>();
                        Directory.CreateDirectory(Application.StartupPath + "/data/" + name + "/" + g.appid);
                        createPanel(g,acc);
                    }
                }
                addContextMenuItem(acc);
                File.WriteAllText(Application.StartupPath + "/data/" + name + "/accountData.json", JsonConvert.SerializeObject(acc));
            new ErrorWindow("API key is valid. Downloading covers!", "Done!").Show();
            } catch {
             new ErrorWindow("Account credentials are not correct").Show();
            }
        }

        private void addContextMenuItem(Account acc) {
            ToolStripMenuItem newItem = (ToolStripMenuItem)accountMenuItem.DropDownItems.Add(acc.accountName);
            acc.contextMenuItem = newItem;
            newItem.ForeColor = Color.White;
            ToolStripItem tempItem = newItem.DropDownItems.Add("API Key: " + acc.key);
            tempItem.ForeColor = Color.White;
            tempItem.Enabled = false;
            tempItem = newItem.DropDownItems.Add("Steam ID: " + acc.steamId);
            tempItem.ForeColor = Color.White;
            tempItem.Enabled = false;
            newItem = (ToolStripMenuItem)newItem.DropDownItems.Add("Delete");
            newItem.ForeColor = Color.Red;
            ToolStripItem deleteItem = newItem.DropDownItems.Add("Yes");
            deleteItem.ForeColor = Color.Red;
            newItem.DropDownItems.Add("No").ForeColor = Color.White;

            deleteItem.Click += (sender, e) => onAccountDelete(sender, e, acc);
        }

        private void onMouseEnter(object sender, EventArgs e) {
            Panel panel = (Panel)sender;
            panel.BorderStyle = BorderStyle.Fixed3D;
            this.lastHovedPanel = panel;
            bannedMenuItem.Checked = panelGame[panel].banned;
        }

        private void onMouseLeave(object sender, EventArgs e) {
            Panel panel = (Panel)sender;
            panel.BorderStyle = BorderStyle.None;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            if(config.toTrayOnClose)
                Hide();
            else
                this.Close();
        }
        public static Image FromFile(string path) {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = Image.FromStream(ms);
            return img;
        }

        private static Stream CopyAndClose(Stream inputStream) {
            const int readSize = 256;
            byte[] buffer = new byte[readSize];
            MemoryStream ms = new MemoryStream();

            int count = inputStream.Read(buffer, 0, readSize);
            while(count > 0) {
                ms.Write(buffer, 0, count);
                count = inputStream.Read(buffer, 0, readSize);
            }
            ms.Position = 0;
            inputStream.Close();
            return ms;
        }

        public bool IsProcessOpen(string name) {
            foreach(Process clsProcess in Process.GetProcesses()) {
                if(clsProcess.ProcessName.Contains(name)) {
                    return true;
                }
            }
            return false;
        }

        private void onGameDoubleClick(object sender, EventArgs e) {
            if(config.steamPath != null) {
                Process proc = Process.GetProcessesByName("steam").FirstOrDefault();
                if(proc != null)
                    proc.Kill();
                if(config.onlyLogin) {
                    ExecuteAsAdmin(config.steamPath, "-login " + panelAccount[lastHovedPanel].accountName + " " + panelAccount[lastHovedPanel].accountPass);
                } else {
                    ExecuteAsAdmin(config.steamPath, "-login " + panelAccount[lastHovedPanel].accountName + " " + panelAccount[lastHovedPanel].accountPass + " -applaunch " + panelGame[lastHovedPanel].appid);
                }
                if(config.minimize)
                    Hide();
            } else {
                new ErrorWindow("Steam path is not set! Please set the path to your steam.exe via right click on any game.").Show();
            }
        }

        public void ExecuteAsAdmin(string fileName, String arguments = "") {
            try {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.Arguments = arguments;
                proc.StartInfo.Verb = "runas";
                proc.Start();
            } catch (Win32Exception) {
                if(config.minimize)
                    Show();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            Form addForm = new AddAccountWindow(this);
            addForm.Show();
        }

        private void vACedToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(lastHovedPanel != null) {
                item.Checked = !item.Checked;
                Game g = panelGame[lastHovedPanel];
                g.banned = item.Checked;
                var ripLabel = lastHovedPanel.Controls.Find("ripLabel", false).FirstOrDefault();
                if(ripLabel != null) {
                    ripLabel.Visible = item.Checked;
                }
                File.WriteAllText(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid + "/gameData.json", JsonConvert.SerializeObject(g));
            }

        }

        private void searchBtn_Click(object sender, EventArgs e) {
            flowPanel.SuspendLayout();
            foreach(KeyValuePair<Panel, Game> entry in panelGame) {
                if(entry.Value.name.ToLower().Contains(searchBox.Text.ToLower())) {
                    entry.Key.Visible = true;
                } else if(entry.Value.accountName != null && entry.Value.accountName.ToLower().Contains(searchBox.Text.ToLower())) {
                    entry.Key.Visible = true;
                } else {
                    entry.Key.Visible = false;
                }
            }
            flowPanel.ResumeLayout();
        }

        private void minimizeOnLauchToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            config.minimize = !config.minimize;
            item.Checked = config.onlyLogin;
            File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
        }

        private void loginOnlyToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            config.onlyLogin = !config.onlyLogin;
            item.Checked = config.onlyLogin;
            File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
        }

        private void selectSteamExToolStripMenuItem_Click(object sender, EventArgs e) {
            using(OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.FileName = "Steam.exe";
                openFileDialog.Filter = "Executables (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if(openFileDialog.ShowDialog() == DialogResult.OK) {
                    config.steamPath = openFileDialog.FileName;
                    File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
                }
            }
        }

        private void selectPlaceholderCoverToolStripMenuItem_Click(object sender, EventArgs e) {
            using(OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.FileName = "Steam.exe";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if(openFileDialog.ShowDialog() == DialogResult.OK) {
                    config.placeHolderCover = openFileDialog.FileName;
                    File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
                    flowPanel.SuspendLayout();
                    foreach(KeyValuePair<Panel, Game> entry in panelGame) {
                        if(!File.Exists(Application.StartupPath + "/data/" + entry.Value.accountName + "/" + entry.Value.appid + "/cover.jpg")) {
                            entry.Key.BackgroundImage = FromFile(openFileDialog.FileName);
                        }
                    }
                    flowPanel.ResumeLayout();
                }
            }
        }

        private void theme_Resize(object sender, EventArgs e) {
            theme.AccentOffset = -Convert.ToInt32(theme.Width * 0.9);
        }

        private void minimizeBtn_Click(object sender, EventArgs e) {
            Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toTrayOnCloseToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            config.toTrayOnClose = !config.toTrayOnClose;
            item.Checked = config.toTrayOnClose;
            File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
        }

        private void setAPIKeyToolStripMenuItem_Click(object sender, EventArgs e) { //Set Steam Grid Api
            Form addForm = new InputSteamGridApi(this);
            addForm.Show();
        }

        private void getAPIKeyToolStripMenuItem_Click(object sender, EventArgs e) { //Get Steam Grid API Key
            Process.Start("https://www.steamgriddb.com/profile/preferences");
        }

        private void enableSlowAsyncToolStripMenuItem_Click(object sender, EventArgs e) { //Enable Steam Grid Db
            if(config.useSteamGridDBKey != null) {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                config.useSteamGridDB = !config.useSteamGridDB;
                item.Checked = config.useSteamGridDB;
                File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
                foreach(KeyValuePair<Panel, Game> entry in panelGame) {
                    if(!entry.Value.hasCover) {
                        entry.Value.usesPlaceholder = false; //TODO Trigger download icons
                        File.WriteAllText(Application.StartupPath + "/data/" + entry.Value.accountName + "/" + entry.Value.appid + "/gameData.json", JsonConvert.SerializeObject(entry.Value));
                        downloadCovers(entry.Key, entry.Value);
                    }
                }
            }
        }

        internal void SteamGridApiKey(string text) {
            config.useSteamGridDBKey = text;
            enableSlowAsyncToolStripMenuItem.Enabled = true;
            GridTipMenuItem.Text = config.useSteamGridDBKey;
            File.WriteAllText(Application.StartupPath + "/data/config.json", JsonConvert.SerializeObject(config));
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight) {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using(var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void openCoverFolderToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(lastHovedPanel != null) {
                Game g = panelGame[lastHovedPanel];
                Process.Start(Application.StartupPath + "/data/" + g.accountName + "/" + g.appid);
            }
        }

        private void openPoolStripMenuItem_Click(object sender, EventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void gameName_ToolTip(object sender, MouseEventArgs e, Game g) {
            toolTip.SetToolTip((Label)sender, g.name);
        }
    }
}
