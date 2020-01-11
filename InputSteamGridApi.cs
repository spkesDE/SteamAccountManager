using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager {
    public partial class InputSteamGridApi : Form
    {

        MainWindow main;
        public InputSteamGridApi(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.main.SteamGridApiKey(apiKey.Text);
            this.Close();
        }

    }
}
