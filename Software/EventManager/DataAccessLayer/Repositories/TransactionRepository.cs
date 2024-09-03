using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TransactionRepository : Repository<Transaction>
    {
        public TransactionRepository() : base(new Model1())
        {

        }

        public override int Update(Transaction entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
        ///<author>Antonijo Hamzić</author>
        public IQueryable<Transaction> GetTransactionsByUser(User user)
        {
            var query = from t in Entities.Include("Event").Include("User")
                        where t.Id_Users == user.Id
                        select t;
            return query;
        }

        public IQueryable<Transaction> GetAllTransactions()
        {
            var query = from t in Entities.Include("Event").Include("User")
                        select t;
            return query;
        }


        public IQueryable<Transaction> GetTransactionsEvent(Event events) ///<author>Toni Leo Modrić Dragičević</author>
        {
            var query = from t in Entities.Include("Event").Include("User")
                        where t.Id_Events == events.Id
                        select t;
            return query;
        }

        public override int Add(Transaction entity, bool saveChanges = true) {
            var transaction = new Transaction {
                Id_Events = entity.Id_Events,
                Id_Users = entity.Id_Users,
                Type = entity.Type,
                Amount=entity.Amount
            };

            Entities.Add(transaction);
            if (saveChanges) {
                return SaveChanges();
            } else {
                return 0;
            }
        }
    }
}
