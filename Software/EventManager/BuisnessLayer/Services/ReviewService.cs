using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    public class ReviewService
    {
        public bool AddReview(Review review)
        {
            bool IsSuccesfull = false;

            using (var repo = new ReviewRepository())
            {
                int affectedRows = repo.Add(review);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }

        public List<Review> GetReviewsByUser(User user)
        {
            using (var repo = new ReviewRepository())
            {
                return repo.GetReviewsByUser(user).ToList();
            }
        }

    }
}
