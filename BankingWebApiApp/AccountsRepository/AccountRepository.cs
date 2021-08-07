using Accounts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsRepository
{
    public class AccountRepository : IAccountRepository
    {
        private BankDbContext _bankDbContext;

        public AccountRepository()
        {
            _bankDbContext = new BankDbContext();
        }

        public Account GetAccount(String userName)
        {
            return _bankDbContext.Accounts.Where(a => a.Name == userName).First();
        }

        public void AddAccount(Account account)
        {
            Transaction transaction;
            transaction = new Transaction {
                TransactionId = Guid.NewGuid(),
                Account = account,
                Amount = account.Balance,
                Time = DateTime.Now,
                Type = TransactionType.D
            };

            account.Transactions = new List<Transaction>();
            account.Transactions.Add(transaction);

            _bankDbContext.Accounts.Add(account);

            _bankDbContext.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            Account oldAccount = _bankDbContext.Accounts.Where(a => a.AccountId == account.AccountId).First();

            oldAccount.Balance = account.Balance;
            oldAccount.Email = account.Email;
            oldAccount.Name = account.Name;

            _bankDbContext.SaveChanges();
        }
    }
}
