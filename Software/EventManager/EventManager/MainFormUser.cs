using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class MainFormUser : Form
    {
        private User loginUser;
        public MainFormUser(User user)
        {
            InitializeComponent();
            loginUser = user;
            helpProvider2.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            var form = new FrmEventManagemenentUser(loginUser);
            form.ShowDialog();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            var form = new FrmTicketsUser();
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
