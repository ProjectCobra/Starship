using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MongoDB.Driver;

namespace CALVRI.Controllers
{
    public class HomeController : Controller
    {
        public MongoDatabase Database;

        public HomeController()
        {
            var port = 27017;
            var theConnectionString = "mongodb://localhost:" + port;
            var dbName = "someDbName";

            var client = new MongoClient(theConnectionString);
            var server = client.GetServer();
            Database = server.GetDatabase(dbName);
            //database.
        }

        

        public ActionResult Index()
        { 

            return View();
        }
        //public ActionResult Index(string CNICnum, string DOB, string NoM)
        //{
        //   
        //    if(!string.IsNullOrEmpty(CNICnum))
        //    {
        //        if(!string.IsNullOrEmpty(DOB))
        //        {
        //            if(!string.IsNullOrEmpty(NoM))
        //            {
        //                var profile = db.CNICProfile.find({ CNICnum : CNICnum, DOB : DOB, NoM : NoM});
        //            }
        //        }
        //    }
        //    return View(profile);
        //}

    }
}