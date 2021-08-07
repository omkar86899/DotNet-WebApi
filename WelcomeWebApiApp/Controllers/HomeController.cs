using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WelcomeWebApiApp.Controllers
{
    public class HomeController: ApiController
    {
        public IHttpActionResult Get()
        {
            return Json("Get Called");
        }

        public IHttpActionResult Post()
        {
            return Json("Post Called");
        }

        public IHttpActionResult Put()
        {
            return Json("Put Called");
        }

        public IHttpActionResult Delete()
        {
            return Json("Delete Called");
        }
    }
}