using BuisnessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class FrmTicketsUser : Form
    {
        private TicketService ticketService = new TicketService();
        public FrmTicketsUser()
        {
            InitializeComponent();
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowAllTickets()
        {
            var tickets = ticketService.GetTickets();
            dgvTickets.DataSource = tickets;
            dgvTickets.Columns["Id_Events"].Visible = false;
            dgvTickets.Columns["Id_Users"].Visible = false;
            dgvTickets.Columns["Id_Category"].Visible = false;
            dgvTickets.Columns["Id_Users"].Visible = false;
            dgvTickets.Columns["User"].Visible = false;
        }

        private void FrmTicketsUser_Load(object sender, EventArgs e)
        {
            ShowAllTickets();
        }
    }
}
