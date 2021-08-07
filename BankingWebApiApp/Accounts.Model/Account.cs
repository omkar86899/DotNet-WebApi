using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Model
{
    public class Account
    {
        [Key]
        public Guid AccountId
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public double Balance
        {
            get;
            set;
        }

        public List<Transaction> Transactions
        {
            get;
            set;
        }
    }
}
