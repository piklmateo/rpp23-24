using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class VenueService
    {

        private static double HaversineDistance(double lat1, double lon1, double lat2, double lon2) {
    
            lat1 = ToRadians(lat1);
            lon1 = ToRadians(lon1);
            lat2 = ToRadians(lat2);
            lon2 = ToRadians(lon2);

     
            double dlat = lat2 - lat1;
            double dlon = lon2 - lon1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

         
            double R = 6371.0;

          
            double distance = R * c;

            return distance;
        }

        private static double ToRadians(double degrees) {
            return degrees * Math.PI / 180.0;
        }



        public List<Venue> GetVenues()
        {
            using (var repo = new VenueRepository())
            {
                List<Venue> venues = repo.GetAllVenues().ToList();
                return venues;
            }
        }

        public List<Venue> GetCloseVenues(double longitude, double latitude ) {
            using (var repo = new VenueRepository()) {
                List<Venue> venues = repo.GetAllVenues().ToList();
                double maxDistance = 100.0; 
                List<Venue> closeVenues = venues
                    .Where(venue =>
                     venue.Latitude.HasValue &&
                       venue.Longitude.HasValue &&
                        HaversineDistance(latitude, longitude, Convert.ToDouble( venue.Latitude),Convert.ToDouble( venue.Longitude)) <= maxDistance)
                    .ToList();
                return closeVenues;
            }
        }

        public bool AddVenue(Venue venue)
        {
            bool IsSuccesfull = false;

            using (var repo = new VenueRepository())
            {
                int affectedRows = repo.Add(venue);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public bool UpdateVenue(Venue venue)
        {
            bool IsSuccesfull = false;

            using (var repo = new VenueRepository())
            {
                int affectedRows = repo.Update(venue);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }
    }
}
