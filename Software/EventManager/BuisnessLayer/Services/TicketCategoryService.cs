using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    public class TicketCategoryService
    {
        public List<TicketCategory> GetTicketCategories()
        {
            using (var repo = new TicketCategoryRepository())
            {
                List<TicketCategory> ticketCategories = repo.GetTicketCategories().ToList();
                return ticketCategories;
            }
        }

        public bool AddTicketCategory(TicketCategory ticketCategory)
        {
            bool IsSuccesfull = false;

            using (var repo = new TicketCategoryRepository())
            {
                int affectedRows = repo.Add(ticketCategory);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool UpdateTicketCategory(TicketCategory ticketCategory)
        {
            bool IsSuccesfull = false;

            using (var repo = new TicketCategoryRepository())
            {
                int affectedRows = repo.Update(ticketCategory);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }
    }
}
