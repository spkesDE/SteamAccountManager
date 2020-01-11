using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager
{
    public partial class AddAccountWindow : Form
    {
        private MainWindow main;
        public AddAccountWindow(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void accNameCancel_Click(object sender, EventArgs e)
        {
            accName.ResetText();
        }

        private void accountPassCancel_Click(object sender, EventArgs e)
        {
            accountPass.ResetText();
        }

        private void steamIdCancel_Click(object sender, EventArgs e)
        {
            steamId.ResetText();
        }

        private void apiKeyCancel_Click(object sender, EventArgs e)
        {
            apiKey.ResetText();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            main.addAccount(accName.Text, accountPass.Text, steamId.Text, apiKey.Text);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getApiKey_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://steamcommunity.com/dev/apikey");
        }

        private void getSteamId_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://steamid.io/");
        }
    }
}
