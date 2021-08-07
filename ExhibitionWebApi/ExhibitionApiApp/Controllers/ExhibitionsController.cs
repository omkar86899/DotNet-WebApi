using Exhibitions.Model;
using Exhibitions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ExhibitionApiApp.Controllers
{
    [RoutePrefix("api/v1/organizers/{organizerId}/exhibitions")]
    public class ExhibitionsController: ApiController
    {
        private IExhibitionService _exhibitionService;
        public ExhibitionsController(IExhibitionService exhibitionService)
        {
            _exhibitionService = exhibitionService;
        }

        [Route("")]
        public IHttpActionResult GetExhibitions(Guid organizerId)
        {
            List<Exhibition> exhibitions;

            try
            {
                exhibitions = _exhibitionService.GetExhibitions(organizerId);
            }catch(Exception exception)
            {
                return InternalServerError(exception);
            }

            if(exhibitions.Count == 0)
            {
                return BadRequest("No Exhibitions Found");
            }
            return Ok(_exhibitionService.GetExhibitions(organizerId));
        }

        [Route("{exhibitionId}")]
        public IHttpActionResult GetExhibitions(Guid organizerId, Guid exhibitionId)
        {
            Exhibition exhibition;

            try
            {
                exhibition = _exhibitionService.GetExhibition(organizerId, exhibitionId);
            }catch(Exception exception)
            {
                return InternalServerError(exception);
            }
            if(exhibition == null)
            {
                return BadRequest("No Exhibition Found");
            }
            return Ok(exhibition);
        }
    }
}