using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CALVRI.Controllers
{
    public class CNICController : Controller
    {
        // GET: CNIC Profile
        public ActionResult Index()
        {
            return View();
        }

        //POST: Paychallan
        [HttpPost]
        public ActionResult Paychallan()
        {
            return View();
        }

        //POST: Pay Road Tax
        [HttpPost]
        public ActionResult PayRT()
        {
            return View();
        }

        //POST: Paychallan
        [HttpPost]
        public ActionResult LicenseRenew()
        {
            return View();
        }

        //GET: License Details
        public ActionResult License()
        {
            return View();
        }

        //GET: Challan Details
        public ActionResult Challan()
        {
            return View();
        }

        //GET: RoadTax Details
        public ActionResult RoadTax()
        {
            return View();
        }
    }
}