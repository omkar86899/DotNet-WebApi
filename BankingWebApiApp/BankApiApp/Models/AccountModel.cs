using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApiApp.Models
{
    public class AccountModel
    {
        [Required]
        public String Name
        {
            get;
            set;
        }

        [Required]
        public String Email
        {
            get;
            set;
        }

        [Required]
        public String Password
        {
            get;
            set;
        }

        [Required]
        [Range(500, double.MaxValue)]
        public double Balance
        {
            get;
            set;
        }
    }
}