using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DataAccessLayer.Iznimke;
using System.Data.Entity;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository() : base(new Model1())
        {
            
        }

        public override IQueryable<User> GetAll()
        {
            var query = from u in Entities
                        select u;
            return query;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await Entities.SingleOrDefaultAsync(u => u.Username == username);
            ValidacijaLogin(username, password, user);
            if (user != null && VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }

        public override int Add(User entity, bool saveChanges = true)
        {
            ValidacijaRegistracija(entity);

            var role = Context.Roles.SingleOrDefault(v => v.Id == entity.Id_Roles);

            var user = new User
            {
                Name = entity.Name,
                Surname = entity.Surname,
                Address = entity.Address,
                Phone = entity.Phone,
                Username = entity.Username,
                Password = HashPassword(entity.Password),
                Role = role
            };

            Entities.Add(user);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string password, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashPassword);
        }

        public override int Update(User entity, bool saveChanges = true)
        {
            var user = Context.Users.SingleOrDefault(e => e.Id == entity.Id);

            user.Name = entity.Name;
            user.Surname = entity.Surname;
            user.Phone = entity.Phone;
            user.Username = entity.Username;
            user.Address = entity.Address;
            user.Password = entity.Password;
            user.Role = entity.Role;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public User GetById(User entity)
        {
            var user = Context.Users.SingleOrDefault(e => e.Id == entity.Id);
            return user;
        }

        private void ValidacijaRegistracija(User entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Username) ||
                string.IsNullOrWhiteSpace(entity.Password) ||
                string.IsNullOrWhiteSpace(entity.Phone) ||
                string.IsNullOrWhiteSpace(entity.Surname) ||
                string.IsNullOrWhiteSpace(entity.Name) ||
                string.IsNullOrWhiteSpace(entity.Address) ||
                entity.Id_Roles == 0)
            {
                throw new UserException("Molimo Vas da ispunite sva potrebna polja");
            }

            if (Entities.Any(u => u.Username == entity.Username))
            {
                throw new UserException("Korisničko ime već postoji");
            }
        }

        private void ValidacijaLogin(string username, string password, User user)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new UserException("Molimo Vas da unesete korisničko ime.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new UserException("Molimo Vas da unesete lozinku.");
            }

            if(user == null)
            {
                throw new UserException("Pogrešno korisničko ime ili lozinka");
            }

            if(VerifyPassword(password, user.Password) == false)
            {
                throw new UserException("Pogrešno korisničko ime ili lozinka");
            }
        }

    }
}
