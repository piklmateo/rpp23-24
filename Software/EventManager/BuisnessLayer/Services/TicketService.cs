using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    public class TicketService
    {
        public List<Ticket> GetTickets()
        {
            using (var repo = new TicketRepository())
            {
                List<Ticket> tickets = repo.GetAll().ToList();
                return tickets;
            }
        }

        public bool AddTicket(Ticket ticket)
        {
            bool IsSuccesfull = false;

            using (var repo = new TicketRepository())
            {
                int affectedRows = repo.Add(ticket);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool UpdateTicket(Ticket ticket)
        {
            bool IsSuccesfull = false;

            using (var repo = new TicketRepository())
            {
                int affectedRows = repo.Update(ticket);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool RemoveTicket(Ticket ticket)
        {
            bool IsSuccesfull = false;
            bool canRemove = CheckIfTicketCanBeRemoved(ticket);

            if (canRemove)
            {
                using (var repo = new TicketRepository())
                {
                    int affectedRows = repo.Remove(ticket);
                    IsSuccesfull = affectedRows > 0;
                }
            }
            return IsSuccesfull;
        }

        private bool CheckIfTicketCanBeRemoved(Ticket ticket)
        {
            if (ticket == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Ticket> GetTicketsByUser(User user)
        {
            using (var repo = new TicketRepository())
            {
                List<Ticket> tickets = repo.GetAllUserTickets(user).ToList();
                return tickets;
            }
        }

        public List<Ticket> GetTicketsByEvent(Event selectedEvent) {
            using (var repo = new TicketRepository()) {
                List<Ticket> tickets = repo.GetAllEventTickets(selectedEvent).ToList();
                return tickets;
            }
        }
    }
}
