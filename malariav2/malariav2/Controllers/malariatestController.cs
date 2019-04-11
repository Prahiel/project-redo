using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using malariav2.Models;
using System.Dynamic;

namespace malariav2.Controllers
{
    public class malariatestController : ApiController
    {
        [System.Web.Http.Route("api/malariatest/getlog")]
        [System.Web.Mvc.HttpPost]

        public IEnumerable<Malaria_Log>getlog()
        {
            MalariaEntities db = new MalariaEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Malaria_Log.ToList();
        }

    }
}
