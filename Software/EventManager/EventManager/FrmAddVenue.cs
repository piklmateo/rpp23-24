using BuisnessLayer;
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
    public partial class FrmAddVenue : Form
    {
        private VenueService venueService = new VenueService();
        public FrmAddVenue()
        {
            InitializeComponent();
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            var newVenue = new Venue
            {
                Name = txtVenueName.Text,
                Description = txtVenueDescription.Text,
                Longitude = decimal.Parse(txtLongitude.Text),
                Latitude = decimal.Parse(txtLatitude.Text)
            };

            if (newVenue.Name != "" && newVenue.Description != "" && newVenue.Latitude != null && newVenue.Longitude != null)
            {
                venueService.AddVenue(newVenue);
                MessageBox.Show("Uspješno dodan novi prostor");
                Close();
            }
            else
            {
                MessageBox.Show("Molimo Vas da ispunite sve podatke");
            }
        }
    }
}
