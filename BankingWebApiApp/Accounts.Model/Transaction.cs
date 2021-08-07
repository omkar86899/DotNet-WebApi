using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Model
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId
        {
            get;
            set;
        }

        public TransactionType Type
        {
            get;
            set;
        }

        public double Amount
        {
            get;
            set;
        }

        public DateTime Time
        {
            get;
            set;
        }

        public Account Account
        {
            get;
            set;
        }
    }
}
