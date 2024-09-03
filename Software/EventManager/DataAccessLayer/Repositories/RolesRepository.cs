using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RolesRepository : Repository<Role>
    {
        public RolesRepository() : base(new Model1())
        {
             
        }
        public override IQueryable<Role> GetAll()
        {
            var query = from r in Entities
                        select r;
            return query;
        }

        public override int Update(Role entity, bool saveChanges = true)
        {
            var role = Context.Roles.SingleOrDefault(e => e.Id == entity.Id);

            role.Name = entity.Name;

            if (saveChanges)
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
