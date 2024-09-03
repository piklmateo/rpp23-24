using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class CategoryService
    {
        public List<EventCategory> GetEventCategories()
        {
            using (var repo = new CategoryRepository())
            {
                List<EventCategory> eventCategories = repo.GetAllCategories().ToList();
                return eventCategories;
            }
        }

        public bool AddCategory(EventCategory category)
        {
            bool IsSuccesfull = false;

            using (var repo = new CategoryRepository())
            {
                int affectedRows = repo.Add(category);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool UpdateCategory(EventCategory category)
        {
            bool IsSuccesfull = false;

            using (var repo = new CategoryRepository())
            {
                int affectedRows = repo.Update(category);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }
    }
}
