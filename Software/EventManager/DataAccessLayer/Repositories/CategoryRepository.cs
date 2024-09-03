using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : Repository<EventCategory>
    {

        public CategoryRepository() : base(new Model1())
        {

        }

        public IQueryable<EventCategory> GetAllCategories()
        {
            var query = from c in Entities
                        select c;
            return query;
        }

        public override int Update(EventCategory entity, bool saveChanges = true)
        {
            var category = Entities.SingleOrDefault(c => c.Id == entity.Id);

            category.Name = entity.Name;
            
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
