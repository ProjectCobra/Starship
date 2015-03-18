using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CALVRI.Services;
using CALVRI.Models;
using MongoDB.Bson;

namespace CALVRI.Controllers
{
    public class TWardenController : Controller
    {
        private readonly IssueChallan _challanservice;
        private readonly ReportIncident _alertservice;

        public TWardenController()
        {
            _challanservice = new IssueChallan();
            _alertservice = new ReportIncident();
        }

        // GET: TWarden
        public ActionResult Index()
        {
            ulong CNICNo = 3660308805461;
            string col = "twarden";
            MongoHelper<twarden> model = new MongoHelper<twarden>();
            ViewBag.collection = model.Getdb(col);
            ViewBag.profiles = model.Getallprofiles(col);
            ViewBag.profile = model.Get_tw_profile(CNICNo,col);
            return View();
        }

        [HttpGet]
        public ActionResult IssueChallan()
        {
            return View(new challan());
            //return View();
        }

        [HttpPost]
        public ActionResult Create(challan challan)
        {
            if (ModelState.IsValid)
            {
                cnic violator = new cnic();
                //challan. = challan.Title.GenerateSlug();
                challan.WardenName = User.Identity.Name;
                challan.DateofViolation = DateTime.Now;

                //_challanservice.AddChallan(violator,challan);

                return RedirectToAction("Index");
            }

            return View();
        }
        // POST: Report Incident 
        public ActionResult ReportIncident()
        {

            return View();
        }

        // GET: Statistics
        public ActionResult Statistics()
        {
            return View();
        }

        // GET: Alerts
        public ActionResult Alerts()
        {
            return View();
        }

        // GET: Search
        public ActionResult Search(cnic model, string returnUrl)
        {
            ulong CNICNo = model.CNICNo;
            ulong v_dl = model.DLicense;

            string col = "cnic";
            MongoHelper<cnic> profile = new MongoHelper<cnic>();
            //ViewBag.collection = profile.Getdb(col);
            var v_prof = profile.Get_v_profile(CNICNo, v_dl, col);

            if (v_prof != null)
            {
                String id = v_prof.id.ToString();
                return RedirectToAction("IndexById", "CNIC", new{id = id});
            }
            else
            {
                return RedirectToAction("Notfound", "Home");
            }
        }
    }
}