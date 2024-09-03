using BuisnessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class FrmEventManagemenentUser : Form
    {
        User loginUser;
        private double latitude;
        private double longitude;
        private GeoCoordinateWatcher watcher;
        private EventServices eventServices = new EventServices();
        private CategoryService categoryService = new CategoryService();
        private VenueService venueService = new VenueService();
        public FrmEventManagemenentUser(User user)
        {
            InitializeComponent();
            loginUser = user;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBoxCategories()
        {
            var categories = categoryService.GetEventCategories();
            cbEventCategory.DataSource = categories;
        }

        private void ShowAllEvents()
        {
            var allEvents = eventServices.GetEvents();
            dgvEvents.DataSource = allEvents;
            dgvEvents.Columns["Id_Venue"].Visible = false;
            dgvEvents.Columns["Id_Category"].Visible = false;
            dgvEvents.Columns["Id_Organizer"].Visible = false;
            dgvEvents.Columns["Reviews"].Visible = false;
            dgvEvents.Columns["Transactions"].Visible = false;
            dgvEvents.Columns["Tickets"].Visible = false;
            dgvEvents.Columns["imgUrl"].Visible = false;
        }
        ///<author>Antonijo Hamzić</author>
        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            try
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    if (watcher.Position.Location.IsUnknown)
                    {
                        latitude = 0;
                        longitude = 0;
                    }
                    else
                    {

                        latitude = watcher.Position.Location.Latitude;
                        longitude = watcher.Position.Location.Longitude;
                    }
                }
                else
                {
                    latitude = 0;
                    longitude = 0;
                }
            }
            catch (Exception) { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = txtSearch.Text;
            var events = eventServices.GetEventsByNameAllIncluded(searchQuery);
            dgvEvents.DataSource = events;
        }
        ///<author>Antonijo Hamzić</author>
        private void btnLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Želi te li lokaciju uređaja?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                watcher = new GeoCoordinateWatcher();
                watcher.StatusChanged += Watcher_StatusChanged;
                watcher.Start();
                if (latitude == 0 && longitude == 0)
                    MessageBox.Show("Lokacija nije uspješno dohvaćena , pokušajte ponovno");
                else
                    MessageBox.Show($"Longitude: {longitude}\nLatitude: {latitude}", "Vaša lokacija");

            }
            else if (result == DialogResult.No)
            {
                var form = new FrmLocations();
                form.ShowDialog();
                latitude = form.latitude;
                longitude = form.longitude;
            }

            if (longitude != 0 && latitude != 0)
            {
                var closeVenues = venueService.GetCloseVenues(longitude, latitude);
                var closeEvents = eventServices.GetEventsByVenue(closeVenues);
                dgvEvents.DataSource = closeEvents;
                dgvEvents.Columns["Id_Venue"].Visible = false;
                dgvEvents.Columns["Id_Category"].Visible = false;
                dgvEvents.Columns["Id_Organizer"].Visible = false;
                dgvEvents.Columns["Reviews"].Visible = false;
                dgvEvents.Columns["Transactions"].Visible = false;
                dgvEvents.Columns["Tickets"].Visible = false;
                dgvEvents.Columns["imgUrl"].Visible = false;
            }
        }

        private void FrmEventManagemenentUser_Load(object sender, EventArgs e)
        {
            ShowAllEvents();
            FillComboBoxCategories();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var eventCategory = cbEventCategory.SelectedItem as EventCategory;
            var events = eventServices.GetEventsByCategory(eventCategory);
            dgvEvents.DataSource = events;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShowAllEvents();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedCells.Count > 0)
            {
                var eventSelected = GetSelectedEvent();
                var form = new FrmEventDetailsUser(eventSelected);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No events were selected!");
            }
        }

        private Event GetSelectedEvent()
        {
            return dgvEvents.CurrentRow.DataBoundItem as Event;
        }

        private void btnBuyTicket_Click(object sender, EventArgs e) {
            var selectedEvent= GetSelectedEvent();
            var form = new FrmBuyTicket(selectedEvent,loginUser);
            form.ShowDialog();
        }
    }
}
