using Exhibitions.Model;
using System;
using System.Collections.Generic;

namespace ExhibitionsRepository
{
    public interface IExhibitionRepository
    {
        Exhibition GetExhibition(Guid organizerId, Guid exhibitionId);
        List<Exhibition> GetExhibitions(Guid organizerId);
    }
}