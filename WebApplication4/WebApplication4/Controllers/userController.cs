using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Dynamic;




namespace WebApplication4.Controllers
{
    public class userController : ApiController
    {
        [System.Web.Http.Route("api/Malaria/getusers")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getallusers()
        {
            MalariaEntities db = new MalariaEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getalluserslist(db.UserDetails.ToList());
        }

        private List<dynamic> getalluserslist(List<UserDetail> forclient)
        {
            List<dynamic> dynamicuserlists = new List<dynamic>();
            foreach (UserDetail user in forclient)
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


 //----------------------------------------------------------------------------
        //[System.Web.Http.Route("api/Malaria/getuserwithuserpw")]
        //[System.Web.Mvc.HttpPost]
        //public List<dynamic> getuserwithuserpw()
        //{
        //    MalariaEntities db = new MalariaEntities();
        //    db.Configuration.ProxyCreationEnabled = false;
        //    List<UserDetail> UserDetails = db.UserDetails.Include(zz => zz.UserName).ToList();
        //    return getuserwithuserpwlist(UserDetails);
        //}

        //private List<dynamic> getuserwithuserpwlist(List<UserDetail> forclient)
        //{
        //    List<dynamic> dynamicuserlists = new List<dynamic>();
        //    foreach (UserDetail user in forclient)
        //    {
        //        dynamic dynamicuserlist = new ExpandoObject();
        //        dynamicuserlist.id = user.UserID;
        //        dynamicuserlist.name = user.Name;
        //        dynamicuserlist.DOB = user.DateOfBirth;
        //        dynamicuserlist.email = user.Email;
        //        dynamicuserlist.uname = getusername(user);
        //        dynamicuserlists.Add(dynamicuserlist);
        //    }
        //    return dynamicuserlists;
        //}
        //private List<dynamic> getusername(UserDetail users)
        //{
        //    List<dynamic> dynamicuserlists = new List<dynamic>();
        //    foreach (UserName user in users.UserNames)
        //    {
        //        dynamic dynamicuserlist = new ExpandoObject();
        //        dynamicuserlist.id = user.UserName1;
        //        dynamicuserlists.Add(dynamicuserlist);
        //    }
        //    return dynamicuserlists;
        //}
        //---------------------------------------------------------------------------
        [System.Web.Http.Route("api/Malaria/adduserdetails")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> adduserdetails([FromBody] List<UserDetail> userdetails)
        {
            try
            {
                MalariaEntities db = new MalariaEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.UserDetails.AddRange(userdetails);
                db.SaveChanges();
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
