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
            ViewBag.profile = model.Get_tw_profile(CNICNo, col);
            return View();
        }

        // GET: /CNIC/CNICNo
        //[HttpGet]
        [Route("{controller}/{action}/id:String")]
        public ActionResult IndexById(String id)
        {
            //ulong CNICNo = 3660308805460;
            var v_id = ObjectId.Parse(id);
            string col = "cnic";
            MongoHelper<cnic> model = new MongoHelper<cnic>();
            //ViewBag.collection = model.Getdb(col);
            //ViewBag.profiles = model.Getallprofiles(col);
            //var V_profile = model.Get_tw_profile(CNICNo, col);
            //ViewBag.v_profile = V_profile;
            ViewBag.profile = model.Getprofile(v_id, col);
            return View();
        }
        //POST: Paychallan
        public ActionResult Paychallan()
        {
            return View();
        }

        //POST: Pay Road Tax
        public ActionResult PayRT()
        {
            return View();
        }

        //POST: Paychallan
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