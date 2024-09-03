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
    public partial class FrmAddOrganizer : Form
    {
        private OrganizerService organizerService = new OrganizerService();
        public FrmAddOrganizer()
        {
            InitializeComponent();
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddOrganizer_Click(object sender, EventArgs e)
        {
            var newOrganizer = new Organizer
            {
                Name = txtOrganizerName.Text,
            };

            if (newOrganizer.Name != "")
            {
                organizerService.AddOrganizer(newOrganizer);
                MessageBox.Show("Uspješno dodan novi organizator");
                Close();
            }
            else
            {
                MessageBox.Show("Molimo Vas da ispunite sve podatke");
            }
        }
    }
}
