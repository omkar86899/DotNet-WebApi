using Exhibitions.Model;
using Organizers.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExhibitionsRepository
{
    public class ExhibitionDbContext : DbContext
    {
        public ExhibitionDbContext() : base("name=ExhibitionDbContext")
        {

        }

        public DbSet<Exhibition> Exhibitions
        {
            get;
            set;
        }

        public DbSet<Organizer> Organizers
        {
            get;
            set;
        }
    }
}
