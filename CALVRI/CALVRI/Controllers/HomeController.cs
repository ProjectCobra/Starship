using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CALVRI.Controllers
{
    public class HomeController : Controller
    {
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