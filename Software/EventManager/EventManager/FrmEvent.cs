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
using BuisnessLayer;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;


namespace EventManager
{
    ///<author>Toni Leo Modrić Dragičević</author>
    public partial class FrmEvent : Form
    {
        public User LoginUser { get; }
        public Event EventSelected { get; }

        public FrmEvent(User loginUser, Event eventSelected)
        {
            InitializeComponent();
            LoginUser = loginUser;
            EventSelected = eventSelected;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FrmEvent_Load(object sender, EventArgs e)
        {
            ShowEventsByName();
        }

        private void ShowEventsByName()
        {
            txtEventName.Text = EventSelected.Name;
            txtEventDate.Text = EventSelected.EventDate.ToShortDateString();
            txtStartTime.Text = EventSelected.StartTime.ToString();
            txtVenueName.Text = EventSelected.Venue.Name.ToString();
            txtCategory.Text = EventSelected.EventCategory.Name;
            txtOrganizer.Text = EventSelected.Organizer.Name;

            var vrijednost = EventSelected.Id + LoginUser.Id * 999876;
            string vrijednostQr = vrijednost.ToString();
            GenerateQr(vrijednostQr);
        }

        private void GenerateQr(string vrijednostQr)
        {
            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            var QrData = qRCodeGenerator.CreateQrCode(vrijednostQr, QRCoder.QRCodeGenerator.ECCLevel.H);
            var Qrcode = new QRCoder.QRCode(QrData);

            picQr.Image = Qrcode.GetGraphic(50);
        }
    }
}
