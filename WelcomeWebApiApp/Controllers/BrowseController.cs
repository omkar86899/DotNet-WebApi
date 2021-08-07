using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace WelcomeWebApiApp.Controllers
{
    [RoutePrefix("api/v1/aurionpro")]
    public class BrowseController: ApiController
    {
        [Route("CompanyInformation")]
        public IHttpActionResult GetCompanyInfo()
        {
            Random random = new Random();
            int rand = random.Next(1, 10);
            if (rand == 1)
            {
                return Ok(new
                {
                    Name = "AurionPro",
                    Strength = 10,
                    Address = "thane"
                });
            }

            if(rand == 2)
            {
                return Created("created", "omkar");
            }
            if(rand == 3)
            {
                return Unauthorized();
            }
            if(rand == 4)
            {
                return InternalServerError();
            }
            if(rand == 5)
            {
                return Conflict();
            }
            if(rand == 6)
            {
                HttpStatusCode customStatusCode = (HttpStatusCode)432;
                return Content(customStatusCode, "returned a custom status code");
            }
            return BadRequest("No company Found");
        }
        
    }
}