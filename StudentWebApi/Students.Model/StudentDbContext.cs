using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(): base("name=StudentDbContext")
        {

        }
        public DbSet<Student> Students
        {
            get;
            set;
        }
    }
}
