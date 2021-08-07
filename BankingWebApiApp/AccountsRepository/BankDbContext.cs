using Accounts.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsRepository
{
    public class BankDbContext: DbContext
    {
        public BankDbContext() : base("name=BankDbContext")
        {

        }

        public DbSet<Account> Accounts
        {
            get;
            set;
        }

        public DbSet<Transaction> Transactions
        {
            get;
            set;
        }
    }
}
