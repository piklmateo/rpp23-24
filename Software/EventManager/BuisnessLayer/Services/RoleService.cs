using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class RoleService
    {
        public List<Role> GetRoles()
        {
            using (var repo = new RolesRepository())
            {
                List<Role> roles = repo.GetAll().ToList();
                return roles;
            }
        }

        public bool AddRole(Role role)
        {
            bool IsSuccesfull = false;

            using (var repo = new RolesRepository())
            {
                int affectedRows = repo.Add(role);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        } 
    }
}
