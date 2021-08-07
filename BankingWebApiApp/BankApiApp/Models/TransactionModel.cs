using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApiApp.Models
{
    public class TransactionModel
    {
        [Required]
        public double Amount
        {
            get;
            set;
        }
        
        [Required]
        public Char TransactionType
        {
            get;
            set;
        }
    }
}