using BuisnessLayer;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<author>Antonijo Hamzić</author>

namespace EventManager {
    public partial class FrmCalendar : Form {

        
        int month, year;
        private TicketService ticketService=new TicketService();
        private EventServices eventService = new EventServices();
        private TransactionServices transactionService =new TransactionServices();
        List<Ticket> tickets = new List<Ticket>();
        List<Transaction> transactions = new List<Transaction>();
        User currentUser;

        public FrmCalendar(User user) {
            InitializeComponent();
            currentUser = user;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FrmCalendar_Load(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            getAllEvents();
            displayCalendar(month,year);
        }

        private void getAllEvents() {
            if(currentUser.Id_Roles==1)
           tickets= ticketService.GetTicketsByUser(currentUser);
            else
                transactions=transactionService.GetTransactionsByUser(currentUser);
                
        }

        private void displayCalendar(int month,int year) {
        

            string monthname = DateTimeFormatInfo.InvariantInfo.GetMonthName(month);

            txtMonthYear.Text=monthname+ " "+year;
            


          

            DateTime startofthemonth = new DateTime(year,month,1);

            int days=DateTime.DaysInMonth(year,month);

            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
          
            for (int i=1;i<daysoftheweek;i++) {
                UcBlank ucBlank = new UcBlank();
                flpCalendar.Controls.Add(ucBlank);
            }

            for(int i = 1; i <= days; i++) {
               List<Event> dateEvents;
                DateTime currentDate = new DateTime(year, month, i);
                if (currentUser.Id_Roles == 1)
                    dateEvents = eventService.GetEventsByTicketsAndCurrentDate(tickets, currentDate);
                else
                    dateEvents = eventService.GetEventsByTransactionAndCurrentDate(transactions, currentDate);

                UCDaysCalendar uCDaysCalendar = new UCDaysCalendar(this);
                uCDaysCalendar.days(currentDate);
               if(dateEvents.Any())
                uCDaysCalendar.displayEvent(dateEvents);
                flpCalendar.Controls.Add(uCDaysCalendar);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            flpCalendar.Controls.Clear();


            if (month == 1) {
                year--;
                month = 12;
            }
            else
                month--;

            displayCalendar(month, year);

        
    }

        private void btnNext_Click(object sender, EventArgs e) {

            flpCalendar.Controls.Clear();

            if (month == 12) {
                year++;
                month = 1;
            } else
                month++;

            displayCalendar(month, year);
        }

        public void showSelectedEvents(List<Event> events) {
            dgvEvents.DataSource = events;
            dgvEvents.Columns["Id"].Visible = false;
            dgvEvents.Columns["Id_Venue"].Visible = false;
            dgvEvents.Columns["Id_Organizer"].Visible = false;
            dgvEvents.Columns["Id_Category"].Visible = false;
            dgvEvents.Columns["imgUrl"].Visible = false;
            dgvEvents.Columns["Reviews"].Visible = false;
            dgvEvents.Columns["Tickets"].Visible = false;
            dgvEvents.Columns["Transactions"].Visible = false;
        }
          
    }
}
