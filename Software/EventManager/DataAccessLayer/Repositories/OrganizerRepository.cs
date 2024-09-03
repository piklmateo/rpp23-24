using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OrganizerRepository : Repository<Organizer>
    {
        public OrganizerRepository() : base(new Model1())
        {

        }

        public IQueryable<Organizer> GetAllOrganizers()
        {
            var query = from o in Entities
                        select o;
            return query;
        }

        public override int Add(Organizer entity, bool saveChanges = true)
        {
            var organizer = new Organizer
            {
                Name = entity.Name,
            };

            Entities.Add(organizer);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Organizer entity, bool saveChanges = true)
        {
            var organizer = Entities.SingleOrDefault(o => o.Id == entity.Id);

            organizer.Name = entity.Name;
            
            if(saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
