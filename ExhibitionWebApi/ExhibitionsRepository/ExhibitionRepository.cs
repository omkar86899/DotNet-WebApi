using Exhibitions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExhibitionsRepository
{
    public class ExhibitionRepository : IExhibitionRepository
    {
        private ExhibitionDbContext _db;
        public ExhibitionRepository()
        {
            _db = new ExhibitionDbContext();
        }

        public List<Exhibition> GetExhibitions(Guid organizerId)
        {
            return _db.Exhibitions.Where(e => e.OrganizerId == organizerId).ToList();
        }

        public Exhibition GetExhibition(Guid organizerId, Guid exhibitionId)
        {
            return _db.Exhibitions.Where(e => e.OrganizerId == organizerId && e.ExhibitionId == exhibitionId).First();
        }
    }
}
