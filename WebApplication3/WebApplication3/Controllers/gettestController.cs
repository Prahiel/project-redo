using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class gettestController : ApiController
    {
        [System.Web.Http.Route("api/Malaria/getusers")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getallusers()
        {
            MalariaEntities1 db = new MalariaEntities1();
            db.Configuration.ProxyCreationEnabled = false;
            return getalluserslist(db.UserDetails.ToList());            
        }

        private List<dynamic> getalluserslist(List<UserDetail> forclient)
        {
            List<dynamic> dynamicuserlists = new List<dynamic>();
            foreach(UserDetail user in forclient)
            {
                dynamic dynamicuserlist = new ExpandoObject();
                dynamicuserlist.id = user.UserID;
                dynamicuserlist.name = user.Name;
                dynamicuserlist.DOB = user.DateOfBirth;
                dynamicuserlist.email = user.Email;
                dynamicuserlists.Add(dynamicuserlist);
            }
            return dynamicuserlists;
        }
    }
}
