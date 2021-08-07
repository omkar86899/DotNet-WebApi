using Exhibitions.Model;
using ExhibitionsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibitions.Service
{
    public class ExhibitionService : IExhibitionService
    {
        private ExhibitionRepository _exhibitionRepository;
        public ExhibitionService()
        {
            _exhibitionRepository = new ExhibitionRepository();
        }

        public List<Exhibition> GetExhibitions(Guid organizerId)
        {
            return _exhibitionRepository.GetExhibitions(organizerId);
        }

        public Exhibition GetExhibition(Guid organizerId, Guid exhibitionId)
        {
            return _exhibitionRepository.GetExhibition(organizerId, exhibitionId);
        }
    }
}
