using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class MainForm : Form
    {
        private User loginUser;
        public MainForm(User user)
        {
            InitializeComponent();
            loginUser = user;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            var form = new FrmEventManagement();
            form.ShowDialog();
        }

        //private void btnTestQr_Click(object sender, EventArgs e)
        //{
        //    var form = new FrmEvent();
        //    form.ShowDialog();
        //}

        private void btnTickets_Click(object sender, EventArgs e)
        {
            var form = new FrmTickets(loginUser);
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var form = new FrmProfile(loginUser);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form = new FrmLogin();
            form.Show();
            Close();
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            var form = new FrmChatbot(loginUser);
            form.ShowDialog();
        }
    }
}
