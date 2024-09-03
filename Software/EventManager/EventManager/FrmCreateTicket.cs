using BuisnessLayer;
using BuisnessLayer.Services;
using DataAccessLayer.Iznimke;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class FrmCreateTicket : Form
    {
        private TicketCategoryService ticketCategoryService = new TicketCategoryService();
        private TicketService ticketService = new TicketService();
        private EventServices eventServices = new EventServices();
        private User loginUser;
        private UserService userService = new UserService();
        public FrmCreateTicket(User user)
        {
            InitializeComponent();
            loginUser = userService.GetUserById(user);
        }

        private void FrmCreateTicket_Load(object sender, EventArgs e)
        {
            FillComboBoxCategories();
            FillComboBoxEvents();
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FillComboBoxEvents()
        {
            var events = eventServices.GetEvents();
            cbEvent.DataSource = events;
        }

        private void FillComboBoxCategories()
        {
            var categories = ticketCategoryService.GetTicketCategories();
            cbTicketCategory.DataSource = categories;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();

                var events = cbEvent.SelectedItem as Event;
                var ticketCategory = cbTicketCategory.SelectedItem as TicketCategory;

                var ticket = new Ticket
                {
                    Event = events,
                    TicketCategory = ticketCategory,
                    Price = decimal.Parse(txtPrice.Text),
                    Amount = int.Parse(txtAmount.Text),
                    Id_Users = loginUser.Id
                };

                ticketService.AddTicket(ticket);
                MessageBox.Show("Uspješno dodana nova ulaznica");
                Close();
            }
            catch(TicketException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                throw new TicketException("Cijena ne smije biti prazna.");
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                throw new TicketException("Količina ne smije biti prazna.");
            }

            if (txtPrice.Text.Contains('.'))
            {
                throw new TicketException("Molimo koristite zarez (,) kao decimalni separator za cijenu.");
            }

            string pricePattern = @"^\d+([.,]\d{1,4})?$";
            string amountPattern = @"^\d+$";

            if (!Regex.IsMatch(txtPrice.Text, pricePattern))
            {
                throw new TicketException("Neispravan format cijene. Dozvoljene su samo brojke s maksimalno 4 decimalna mjesta.");
            }

            if (!Regex.IsMatch(txtAmount.Text, amountPattern))
            {
                throw new TicketException("Neispravan format količine. Dozvoljene su samo cijele brojke.");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
