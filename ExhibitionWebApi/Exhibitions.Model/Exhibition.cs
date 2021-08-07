using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibitions.Model
{
    public class Exhibition
    {
        [Key]
        public Guid ExhibitionId
        {
            get;
            set;
        }

        public String ExhibitionName
        {
            get;
            set;
        }

        public String Location
        {
            get;
            set;
        }

        public Guid OrganizerId
        {
            get;
            set;
        }
    }
}
