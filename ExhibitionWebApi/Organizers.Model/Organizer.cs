using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizers.Model
{
    public class Organizer
    {
        [Key]
        public Guid OrganizerId
        {
            get;
            set;
        }

        public String OrganizerName
        {
            get;
            set;
        }
    }
}
