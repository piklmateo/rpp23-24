using DataAccessLayer.Exceptions;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EventRepository : Repository<Event>
    {
        public EventRepository() : base(new Model1())
        {
            
        }

        public override IQueryable<Event> GetAll()
        {
            var query = from e in Entities.Include("EventCategory").Include("Organizer").Include("Venue").Include("Reviews").Include("Tickets").Include("Transactions")
                        select e;   
            return query;  
        }

        public IQueryable<EventProjection> GetAllEvents()
        {
            var query = from e in Entities
                        select new EventProjection
                        {
                            Name = e.Name,
                            EventDate = e.EventDate,
                            StartTime = e.StartTime.Value,
                            Venue = e.Venue.Name,
                            Organizer = e.Organizer.Name,
                            Category = e.EventCategory.Name,
                        };
            return query;
        }

        
        public IQueryable<Event> GetEventsByNameAllIncluded(string phrase)
        {
            var query = from e in Entities.Include("EventCategory").Include("Organizer").Include("Venue")
                        where e.Name.Contains(phrase)
                        select e;
            return query;
        }
        public Event GetEventByName(string phrase)
        {
            var query = from e in Entities.Include("EventCategory").Include("Organizer").Include("Venue")
                        where e.Name.Contains(phrase)
                        select e;
            return query.FirstOrDefault();
        }

        public IQueryable<Event> GetEventsByCategory(EventCategory eventCategory)
        {
            var query = from e in Entities.Include("EventCategory").Include("Organizer").Include("Venue")
                        where e.Id_Category == eventCategory.Id
                        select e;
            return query;
        }

        public override int Add(Event entity, bool saveChanges = true)
        {
            Validacija(entity);

            var category = Context.EventCategories.SingleOrDefault(c => c.Id == entity.Id_Category);
            var organizer = Context.Organizers.SingleOrDefault(v => v.Id == entity.Id_Organizer);
            var venue = Context.Venues.SingleOrDefault(v => v.Id == entity.Id_Venue);

            var events = new Event
            {
                EventCategory = category,
                Organizer = organizer,
                Venue = venue,
                Name = entity.Name,
                EventDate = entity.EventDate,
                StartTime = entity.StartTime,
                imgUrl = entity.imgUrl
            };

            Entities.Add(events);

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Event entity, bool saveChanges = true)
        {
            Validacija(entity);

            var venue = Context.Venues.SingleOrDefault(v => v.Id == entity.Venue.Id);
            var organizer = Context.Organizers.SingleOrDefault(v => v.Id == entity.Organizer.Id);
            var category = Context.EventCategories.SingleOrDefault(c => c.Id == entity.EventCategory.Id);

            var events = Context.Events.SingleOrDefault(e => e.Id == entity.Id);

            events.Venue = venue;
            events.Organizer = organizer;
            events.EventCategory = category;
            events.EventDate = entity.EventDate;
            events.Name = entity.Name;
            events.StartTime = entity.StartTime;
            events.imgUrl = entity.imgUrl;

            if(saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public void Validacija(Event entity)
        {
            if (entity.Id_Category == 0 || entity.EventDate == null || entity.StartTime == null || entity.Id_Venue == 0 || entity.Id_Organizer == 0)
            {
                throw new EventException("Molimo Vas da ispunite sve potrebne podatke za event");
            }
            if (entity.StartTime.Value.Hours > 1 && entity.StartTime.Value.Hours < 7)
            {
                throw new EventException("Event ne može početi prije 7h ili poslije 1h ujutro");
            }
            if (entity.StartTime.Value.Minutes < 0 || entity.StartTime.Value.Minutes > 59)
            {
                throw new EventException("Nepostojeće vrijeme");
            }
            if(entity.EventDate.Date < DateTime.Now.Date)
            {
                throw new EventException("Event ne može biti u prošlosti");
            }
            if(entity.imgUrl == null)
            {
                throw new EventException("Greška vezana uz sliku");
            }
        }
    }
}
