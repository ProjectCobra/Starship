using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CALVRI.Models;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace CALVRI.Controllers
{
    public class CNICController : Controller
    {
        // GET: /CNIC/
        public ActionResult Index()
        {
            ulong CNICNo = 3660308805460;
            string col = "cnic";
            MongoHelper<cnic> model = new MongoHelper<cnic>();
            ViewBag.collection = model.Getdb(col);
            ViewBag.profiles = model.Getallprofiles(col);
            ViewBag.profile = model.Getprofile(CNICNo,col);
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


        //
        // GET: /CNIC/Create

        public ActionResult Create()
        {
            return View();
        }
    }
}