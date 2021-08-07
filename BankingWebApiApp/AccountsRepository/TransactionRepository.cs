using Accounts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsRepository
{
    public class TransactionRepository : ITransactionRepository
    {
        private BankDbContext _bankDbContext;

        public TransactionRepository()
        {
            _bankDbContext = new BankDbContext();
        }

        public List<Transaction> GetTransactions(String userName)
        {
            return _bankDbContext.Transactions.Where(t => t.Account.Name == userName).ToList();
        }

        public void AddTransaction(Transaction transaction, String userName)
        {
            Account account;
            account = _bankDbContext.Accounts.Where(a => a.Name == userName).First();

            account.Transactions = new List<Transaction>();
            account.Transactions.Add(transaction);

            if(transaction.Type == TransactionType.D)
            {
                account.Balance += transaction.Amount;
                _bankDbContext.SaveChanges();
                return;
            }

            account.Balance -= transaction.Amount;

            if(account.Balance < 500)
            {
                throw new Exception("Transaction Unsuccessful");
            }
            _bankDbContext.SaveChanges();
        }
    }
}
