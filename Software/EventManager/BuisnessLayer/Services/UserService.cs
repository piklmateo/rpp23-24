using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class UserService
    {
        public bool RegisterUser(User user)
        {
            bool IsSuccesfull = false;

            using (var repo = new UserRepository())
            {
                int affectedRows = repo.Add(user);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public async Task<User> LoginUser(string username, string password)
        {
            using (var repo = new UserRepository())
            {
                return await repo.Login(username, password);
            }
        }


        public bool UpdateUser(User user)
        {
            bool IsSuccesfull = false;

            using (var repo = new UserRepository())
            {
                int affectedRows = repo.Update(user);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public User GetUserById(User user)
        {
            using (var repo = new UserRepository())
            {
                return repo.GetById(user);
            }
        }
    }
}
