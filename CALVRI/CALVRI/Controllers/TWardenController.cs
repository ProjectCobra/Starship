using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CALVRI.Controllers
{
    public class TWardenController : Controller
    {
        // GET: TWarden
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index(string CNICnum, string DL)
        //{
        //   
        //    if(!string.IsNullOrEmpty(CNICnum))
        //    {
        //        if(!string.IsNullOrEmpty(DL)
        //            {
        //                var profile = db.CNICProfile.find({ CNICnum : CNICnum, DL : DL});
        //            }
        //    }
        //    return View(profile);
        //}

        // POST: Issue Challan
        public ActionResult IssueChallan()
        {
            return View();
        }

        // GET: Statistics
        public ActionResult Statistics()
        {
            return View();
        }

        // GET: Search
        public ActionResult Search()
        {
            return View();
        }
    }
}