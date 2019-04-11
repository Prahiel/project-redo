using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class MalariaLogInController : ApiController
    {
        //public IEnumerable<Malaria_Log> Get()
        //{
        //    using (MalariaEntities2 dd = new MalariaEntities2())
        //    {
        //        return dd.Malaria_Log.ToList();
        //    }
        //}

        public IEnumerable<Malaria_Facts> Get()
        {
            using (MalariaEntities2 dd = new MalariaEntities2())
            {
                return dd.Malaria_Facts.ToList();
            }
        }

        //public IEnumerable<Malaria_Prevention> Get()
        //{
        //    using (MalariaEntities2 dd = new MalariaEntities2())
        //    {
        //        return dd.Malaria_Prevention.ToList();
        //    }
        //}
    }
}
