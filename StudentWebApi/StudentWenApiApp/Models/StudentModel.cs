using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentWebApiApp.Models
{
    public class StudentModel
    {
        public int id
        {
            get;
            set;
        }

        [Range(1, double.MaxValue)]
        public int rollNo
        {
            get;
            set;
        }

        [Required]
        public String name
        {
            get;
            set;
        }

        [Required]
        public int age
        {
            get;
            set;
        }

        [Required]
        public String email
        {
            get;
            set;
        }

        [Required]
        public DateTime date
        {
            get;
            set;
        }

        [Required]
        public bool isMale
        {
            get;
            set;
        }
    }
}