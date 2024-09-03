using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class OrganizerService
    {
        public List<Organizer> GetOrganizers()
        {
            using (var repo = new OrganizerRepository())
            {
                List<Organizer> organizers = repo.GetAllOrganizers().ToList();
                return organizers;
            }
        }

        public bool AddOrganizer(Organizer organizer)
        {
            bool IsSuccesfull = false;

            using (var repo = new OrganizerRepository())
            {
                int affectedRows = repo.Add(organizer);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool UpdateOrganizer(Organizer organizer)
        {
            bool IsSuccesfull = false;

            using (var repo = new OrganizerRepository())
            {
                int affectedRows = repo.Update(organizer);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }
    }
}
