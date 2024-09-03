using DataAccessLayer.Iznimke;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TicketRepository : Repository<Ticket>
    {
        public TicketRepository() : base(new Model1())
        {
            
        }
        public override IQueryable<Ticket> GetAll()
        {
            var query = from t in Entities.Include("Event").Include("TicketCategory")
                        select t;
            return query;
        }

        public override int Add(Ticket entity, bool saveChanges = true)
        {
            Validacija(entity);
            var events = Context.Events.SingleOrDefault(e => e.Id == entity.Event.Id);
            var category = Context.TicketCategories.SingleOrDefault(c => c.Id == entity.TicketCategory.Id);

            var ticket = new Ticket
            {
                Event = events,
                TicketCategory = category,
                Price = entity.Price,
                Amount = entity.Amount,
                Id_Users = entity.Id_Users
            };

            Entities.Add(ticket);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Ticket entity, bool saveChanges = true)
        {
            Validacija(entity);

            var ticket = Entities.SingleOrDefault(t => t.Id == entity.Id);

            var events = Context.Events.SingleOrDefault(e => e.Id == entity.Event.Id);
            var category = Context.TicketCategories.SingleOrDefault(c => c.Id == entity.TicketCategory.Id);

            ticket.Event = events;
            ticket.TicketCategory = category;
            ticket.Price = entity.Price;
            ticket.Amount = entity.Amount;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        public IQueryable<Ticket> GetAllUserTickets(User user)
        {
            var query = from t in Entities.Include("Event").Include("TicketCategory").Include("User")
                        where t.User.Id == user.Id
                        select t;
            return query;
        }

        private void Validacija(Ticket entity)
        {
            if (entity.Event == null)
            {
                throw new TicketException("Event nije odabran ili je neispravan.");
            }
            if (entity.TicketCategory == null)
            {
                throw new TicketException("Kategorija ulaznice nije odabrana ili je neispravna.");
            }


            if (entity.Event.Id <= 0)
            {
                throw new TicketException("Event ima neispravan ID.");
            }
            if (entity.TicketCategory.Id <= 0)
            {
                throw new TicketException("Kategorija ulaznice ima neispravan ID.");
            }


            if (entity.Price <= 0)
            {
                throw new TicketException("Cijena mora biti veća od 0.");
            }
            if (entity.Amount <= 0)
            {
                throw new TicketException("Količina mora biti veća od 0.");
            }
        }
        public IQueryable<Ticket> GetAllEventTickets(Event selectedEvent) {
            var query = from t in Entities.Include("Event").Include("TicketCategory").Include("User")
                        where t.Id_Events == selectedEvent.Id
                        select t;
            return query;
        }
    }
}
