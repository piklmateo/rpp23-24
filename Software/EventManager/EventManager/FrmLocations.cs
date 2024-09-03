using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;
///<author>Antonijo Hamzić</author>
namespace EventManager {
    public partial class FrmLocations : Form {
        public double latitude;
        public double longitude;
        public FrmLocations() {
            InitializeComponent();
        }

        private void FrmLocations_Load(object sender, EventArgs e) {

            gMapControl.DragButton = MouseButtons.Right;
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.Position = new GMap.NET.PointLatLng(0, 0);
            gMapControl.MinZoom = 1;
            gMapControl.MaxZoom = 100;
            gMapControl.Zoom = 0;
            gMapControl.OnMapClick += GMapControl_OnMapClick; ;

        }

        private void GMapControl_OnMapClick(PointLatLng pointClick, MouseEventArgs e) {
             latitude = pointClick.Lat;
             longitude = pointClick.Lng;
            DialogResult result = MessageBox.Show("Are you happy with your location?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Close();
            }
           

        }
    }
}
