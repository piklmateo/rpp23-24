using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    public class TransactionServices
    {///<author>Antonijo Hamzić</author>
        public List<Transaction> GetTransactionsByUser(User user)
        {
            using (var repo = new TransactionRepository())
            {
                List<Transaction> transactions = repo.GetTransactionsByUser(user).ToList();
                return transactions;
            }
        }

        public List<Transaction> GetAllTransactions()
        {
            using (var repo = new TransactionRepository())
            {
                List<Transaction> transactions = repo.GetAllTransactions().ToList();
                return transactions;
            }
        }

        public List<Transaction> GetTransactionsEvent(Event events) ///<author>Toni Leo Modrić Dragičević</author>
        {
            using (var repo = new TransactionRepository())
            {
                List<Transaction> transactions = repo.GetTransactionsEvent(events).ToList();
                return transactions;
            }
        }

        public bool AddTransaction(Transaction transaction) {
            bool IsSuccesfull = false;

            using (var repo = new TransactionRepository()) {
                int affectedRows = repo.Add(transaction);
                IsSuccesfull = affectedRows > 0;
            }
            return IsSuccesfull;
        }
    }
}
