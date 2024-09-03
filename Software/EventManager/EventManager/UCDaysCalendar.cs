using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager {
    public partial class UCDaysCalendar : UserControl {
        private FrmCalendar frmCalendar;
        private List<Event> events;
        public UCDaysCalendar(FrmCalendar frm) {
            InitializeComponent();
            frmCalendar = frm;
        }

        private void UCDaysCalendar_Load(object sender, EventArgs e) {

        }

        public void days(DateTime date) {
            DateTime currentDate = DateTime.Now;
            txtDaysCalendar.Text = date .Day+ " ";
            if (date.Date == currentDate.Date)
               this.BackColor = Color.CadetBlue;

        }


        public void displayEvent(List<Event> dateEvents) {
        
            btnShowEventInfo.Visible = true;
            events = dateEvents;
        }

        private void btnShowEventInfo_Click(object sender, EventArgs e) {
           
            frmCalendar.showSelectedEvents(events);
        }
    }
}
