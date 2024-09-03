using DataAccessLayer.Exceptions;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class EventServices
    {
        public List<Event> GetEvents()
        {
            using (var repo = new EventRepository())
            {
                List<Event> events = repo.GetAll().ToList();
                return events;
            }
        }

        public List<Event> GetEventsByNameAllIncluded(string phrase)
        {
            using (var repo = new EventRepository())
            {
                List<Event> events = repo.GetEventsByNameAllIncluded(phrase).ToList();
                return events;
            }
        }

        public Event GetEventByName(string phrase)
        {
            using (var repo = new EventRepository())
            {
                Event events = repo.GetEventByName(phrase);
                return events;
            }
        }


        public List<Event> GetEventsByVenue(List<Venue> closeVenues) {
            using (var repo = new EventRepository()) {
                List<Event> events = repo.GetAll().ToList();

              
                List<Event> eventsByVenue = events
                    .Where(e => closeVenues.Any(v => v.Id == e.Id_Venue))
                    .ToList();

                return eventsByVenue;
            }
        }
        ///<author>Antonijo Hamzić</author>
        public List<Event> GetEventsByTicketsAndCurrentDate(List<Ticket> tickets,DateTime currentDate) {
            using (var repo = new EventRepository()) {
                List<Event> events = repo.GetAll().ToList();


                List<Event> eventsByTickets = events
                    .Where(e => tickets.Any(v => v.Id_Events == e.Id))
                    .ToList();

                List<Event> eventsByCurrentDate = eventsByTickets
                 .Where(e => e.EventDate.Date == currentDate.Date)
                 .ToList();

                return eventsByCurrentDate;
            }
        }
        ///<author>Antonijo Hamzić</author>
        public List<Event> GetEventsByTransactionAndCurrentDate(List<Transaction> transactions, DateTime currentDate) {
            using (var repo = new EventRepository()) {
                List<Event> events = repo.GetAll().ToList();


                List<Event> eventsByTickets = events
                    .Where(e => transactions.Any(v => v.Id_Events == e.Id))
                    .ToList();

                List<Event> eventsByCurrentDate = eventsByTickets
                 .Where(e => e.EventDate.Date == currentDate.Date)
                 .ToList();

                return eventsByCurrentDate;
            }
        }




        public List<Event> GetEventsByCategory(EventCategory eventCategory)
        {
            using (var repo = new EventRepository())
            {
                List<Event> events = repo.GetEventsByCategory(eventCategory).ToList();
                return events;
            }
        }


        public bool AddEvent(Event events) 
        {
            bool IsSuccesfull = false;

            using (var repo = new EventRepository()) 
            {
                int affectedRows = repo.Add(events);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool UpdateEvent(Event events)
        {
            bool IsSuccesfull = false;

            using (var repo = new EventRepository())
            {
                int affectedRows = repo.Update(events);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool RemoveEvent(Event events)
        {
            bool IsSuccesfull = false;
            bool canRemove = CheckIfEventCanBeRemoved(events);

            if(canRemove)
            {
                using (var repo = new EventRepository())
                {
                    int affectedRows = repo.Remove(events);
                    IsSuccesfull = affectedRows > 0;
                }
            }
            return IsSuccesfull;
        }

        private bool CheckIfEventCanBeRemoved(Event events)
        {
            if(events == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Event> GetEventsByUser(List<Ticket> userTickets)
        {
            using (var repo = new EventRepository())
            {
                List<Event> events = repo.GetAll().ToList();

                List<Event> userEvents = events
                    .Where(e => userTickets.Any(t => t.Id_Events == e.Id))
                    .ToList();

                return userEvents;
            }
        }
        
    }
}
