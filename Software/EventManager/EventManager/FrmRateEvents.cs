using BuisnessLayer.Services;
using BuisnessLayer;
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

namespace EventManager
{
    public partial class FrmRateEvents : Form
    {
        private User loginUser;
        private UserService userService;
        private TicketService ticketService;
        private EventServices eventServices;
        private ReviewService reviewService;
        public FrmRateEvents(User user)
        {
            InitializeComponent();
            userService = new UserService();
            loginUser = userService.GetUserById(user);
            ticketService = new TicketService();
            eventServices = new EventServices();
            reviewService = new ReviewService();
        }

        private void ShowUserUnratedEvents()
        {
            var events = GetUserUnratedEvents();
            dgvRateEvents.DataSource = events;
            dgvRateEvents.Columns["Id"].Visible = false;
            dgvRateEvents.Columns["Id_Venue"].Visible = false;
            dgvRateEvents.Columns["Id_Organizer"].Visible = false;
            dgvRateEvents.Columns["Id_Category"].Visible = false;
            dgvRateEvents.Columns["imgUrl"].Visible = false;
            dgvRateEvents.Columns["Reviews"].Visible = false;
            dgvRateEvents.Columns["Tickets"].Visible = false;
            dgvRateEvents.Columns["Transactions"].Visible = false;
        }

        private List<Event> GetUserUnratedEvents()
        {
            var userReviews = reviewService.GetReviewsByUser(loginUser);
            var userTickets = ticketService.GetTicketsByUser(loginUser);
            var events = eventServices.GetEventsByUser(userTickets);

            var unratedEvents = new List<Event>();
            foreach (var e in events)
            {
                if(userReviews.FirstOrDefault(r => r.Event.Id == e.Id) == null)
                {
                    unratedEvents.Add(e);
                }
            }

            return unratedEvents;
        }

        private void FrmRateEvents_Load(object sender, EventArgs e)
        {
            ShowUserUnratedEvents();
        }

        private Event GetSelectedEvent()
        {
            if (dgvRateEvents.CurrentRow != null)
            {
                return dgvRateEvents.CurrentRow.DataBoundItem as Event;
            } else
            {
                return null;
            }
        }

        private void btnRateEvent_Click(object sender, EventArgs e)
        {
            Event selectedEvent = GetSelectedEvent();
            if (selectedEvent != null)
            {
                var form = new FrmRateEvent(selectedEvent, loginUser);
                form.ShowDialog();
            } else
            {
                MessageBox.Show("Didn't select the event!");
            }
            ShowUserUnratedEvents();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
