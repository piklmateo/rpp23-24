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
    public partial class FrmUpdateTicket : Form
    {
        private EventServices eventServices = new EventServices();
        private TicketCategoryService ticketCategoryService = new TicketCategoryService();
        private TicketService ticketService = new TicketService();
        private Ticket Ticket;
        public FrmUpdateTicket(Ticket ticket)
        {
            InitializeComponent();
            Ticket = ticket;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUpdateTicket_Load(object sender, EventArgs e)
        {
            FillComboBoxEvents();
            SelectEvent(Ticket.Event.Id);

            txtPrice.Text = Ticket.Price.ToString();
            txtAmount.Text = Ticket.Amount.ToString();

            FillComboBoxTicketCategory();
            SelectTicketCategory(Ticket.TicketCategory.Id);
        }

        private void FillComboBoxTicketCategory()
        {
            var ticket = ticketCategoryService.GetTicketCategories();
            cbTicketCategory.DataSource = ticket;
        }

        private void SelectTicketCategory(int ticketCategoryID)
        {
            for (int i = 0; i < cbTicketCategory.Items.Count; i++)
            {
                TicketCategory ticketCategory = cbTicketCategory.Items[i] as TicketCategory;
                if (ticketCategory.Id == ticketCategoryID)
                {
                    cbTicketCategory.SelectedIndex = i;
                    break;
                }
            }
        }

        private void FillComboBoxEvents()
        {
            var events = eventServices.GetEvents();
            cbEvent.DataSource = events;
        }

        private void SelectEvent(int eventID)
        {
            for (int i = 0; i < cbEvent.Items.Count; i++)
            {
                Event events = cbEvent.Items[i] as Event;
                if (events.Id == eventID)
                {
                    cbEvent.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();
                TicketCategory ticketCategory = cbTicketCategory.SelectedItem as TicketCategory;
                Event events = cbEvent.SelectedItem as Event;

                Ticket.TicketCategory = ticketCategory;
                Ticket.Event = events;
                Ticket.Price = Convert.ToDecimal(txtPrice.Text);
                Ticket.Amount = Convert.ToInt32(txtAmount.Text);

                var ticketService = new TicketService();
                ticketService.UpdateTicket(Ticket);
                MessageBox.Show("Uspješno ažurirana ulaznica");
                Close();
            }
            catch (TicketException ex)
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

    }
}
