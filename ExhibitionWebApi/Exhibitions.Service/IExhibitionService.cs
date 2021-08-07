using Exhibitions.Model;
using System;
using System.Collections.Generic;

namespace Exhibitions.Service
{
    public interface IExhibitionService
    {
        Exhibition GetExhibition(Guid organizerId, Guid exhibitionId);
        List<Exhibition> GetExhibitions(Guid organizerId);
    }
}