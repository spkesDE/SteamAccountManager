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
    public partial class ErrorWindow : Form
    {
        public ErrorWindow(String Message, String title = "Error!")
        {
            InitializeComponent();
            theme.Text = title;
            errorMsg.Text = Message;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
