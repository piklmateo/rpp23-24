using BuisnessLayer;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;
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
    public partial class FrmTickets : Form
    {
        private TicketService ticketService = new TicketService();
        private UserService userService = new UserService();
        private User loginUser;
        public FrmTickets(User user)
        {
            InitializeComponent();
            loginUser = userService.GetUserById(user);
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FrmTickets_Load(object sender, EventArgs e)
        {
            ShowAllTickets();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new FrmCreateTicket(loginUser);
            form.ShowDialog();
            ShowAllTickets();
        }


        private Ticket GetSelectedTicket()
        {
            return dgvTickets.CurrentRow.DataBoundItem as Ticket;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedTicket = GetSelectedTicket();
            if (selectedTicket != null)
            {
                bool isSuccesfull = ticketService.RemoveTicket(selectedTicket);
                if (isSuccesfull)
                {
                    MessageBox.Show("Uspješno brisanje");
                    ShowAllTickets();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja");
                }
            }
            ShowAllTickets();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedTicket = GetSelectedTicket();

            if (selectedTicket != null)
            {
                var form = new FrmUpdateTicket(selectedTicket);
                form.ShowDialog();
                ShowAllTickets();
            }
            else
            {
                MessageBox.Show("Molimo Vas da odaberete Ticket koji želite izmijeniti");
            }  
        }
    }
}
