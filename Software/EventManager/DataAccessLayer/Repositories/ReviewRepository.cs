using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataAccessLayer.Repositories
{
    public class ReviewRepository : Repository<Review>
    {
        public ReviewRepository() : base(new Model1())
        {
        }

        public override int Update(Review entity, bool saveChanges = true)
        {
            var eventReview = Context.Events.SingleOrDefault(e => e.Id == entity.Event.Id);
            var user = Context.Users.SingleOrDefault(e => e.Id == entity.User.Id);

            var review = Context.Reviews.SingleOrDefault(r => r.Id == entity.Id);

            review.Rate = entity.Rate;
            review.Recommend = entity.Recommend;
            review.Comment = entity.Comment;
            review.Event = eventReview;
            review.User = user;

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override int Add(Review entity, bool saveChanges = true)
        {
            var eventReview = Context.Events.SingleOrDefault(e => e.Id == entity.Event.Id);
            var user = Context.Users.SingleOrDefault(e => e.Id == entity.User.Id);

            var review = new Review
            {
                Rate = entity.Rate,
                Recommend = entity.Recommend,
                Comment = entity.Comment,
                Event = eventReview,
                User = user
            };

            Context.Reviews.Add(review);

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }   
    
        public IQueryable<Review> GetReviewsByUser(User user)
        {
            var query = from r in Entities.Include("Event").Include("User")
                        where r.User.Id == user.Id
                        select r;
            return query;
        }
    }
}
