using BuisnessLayer;
using DataAccessLayer.Exceptions;
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
    public partial class FrmAddEvent: Form
    {
        private CategoryService categoryService = new CategoryService();
        private VenueService venueService = new VenueService();
        private OrganizerService organizationService = new OrganizerService();
        private EventServices eventServices = new EventServices();
        public FrmAddEvent()
        {
            InitializeComponent();
            
        }
        private void FrmAddEvent_Load(object sender, EventArgs e)
        {
            FillComboBoxCategory();
            FillComboBoxVenue();
            FillComboBoxOrganizer();
            DisablePastDates();
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void DisablePastDates()
        {
            dtpEventDate.MinDate = DateTime.Now;
        }

        private void FillComboBoxOrganizer()
        {
            var organizers = organizationService.GetOrganizers();
            cbOrganizer.DataSource = organizers;
        }

        private void FillComboBoxVenue()
        {
            var venues = venueService.GetVenues();
            cbVenue.DataSource = venues;
        }

        private void FillComboBoxCategory()
        {
            var categories = categoryService.GetEventCategories();
            cbTicketCategory.DataSource = categories;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();

                var newEvent = new Event
                {
                    Name = txtEventName.Text,
                    EventDate = dtpEventDate.Value,
                    StartTime = TimeSpan.Parse(txtStartTime.Text),
                    Id_Category = ((EventCategory)cbTicketCategory.SelectedItem).Id,
                    Id_Organizer = ((Organizer)cbOrganizer.SelectedItem).Id,
                    Id_Venue = ((Venue)cbVenue.SelectedItem).Id,
                    imgUrl = txtImageUrl.Text
                };

                eventServices.AddEvent(newEvent);
                MessageBox.Show("Uspješno dodan event");
                Close();
            }
            catch(EventException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void ValidateInput()
        {
            string eventNamePattern = @"^[a-zA-Z0-9\s\-_]+$";
            if (!Regex.IsMatch(txtEventName.Text, eventNamePattern))
            {
                throw new EventException("Neispravan naziv eventa.");
            }

            string startTimePattern = @"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$";
            if (!Regex.IsMatch(txtStartTime.Text, startTimePattern))
            {
                throw new EventException("Pogrešan format vremena početka. Koristite format HH:mm.");
            }

            if (!TimeSpan.TryParse(txtStartTime.Text, out TimeSpan startTime))
            {
                throw new EventException("Pogrešan unos vremena početka eventa.");
            }

            /*if(txtImageUrl.Text != "")
            {
                string imageUrlPattern = @"^(http(s?):)([/|.|\w|\s|-])*\.(?:jpg|gif|png)$";
;
                if (!Regex.IsMatch(txtImageUrl.Text, imageUrlPattern))
                {
                    throw new EventException("Pogrešan format URL-a slike");
                }
            }*/

            if(txtImageUrl.Text.Length > 400)
            {
                throw new EventException("URL slike ne smije biti duži od 400 znakova.");
            }
        }


        private void btnAddOrganizer_Click(object sender, EventArgs e)
        {
            var form = new FrmAddOrganizer();
            form.ShowDialog();
            FillComboBoxOrganizer();
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            var form = new FrmAddVenue();
            form.ShowDialog();
            FillComboBoxVenue();
        }
    }
}
