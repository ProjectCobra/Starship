using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CALVRI.Models;
using CALVRI.DAL;

namespace CALVRI
{
    public class CNICController : Controller, IDisposable
    {
        private Dal dal = new Dal();
        private bool disposed = false;

        //// GET: CNIC Profile
        //public ActionResult Index()
        //{
        //    return View();
        //}

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


        // GET: /CNIC/

        public ActionResult Index()
        {
            return View(dal.GetProfile());
        }

        //
        // GET: /CNIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CNIC/Create

        [HttpPost]
        public ActionResult Create(CNIC CNIC_profile)
        {
            try
            {
                dal.CreateTask(CNIC_profile);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        # region IDisposable

        new protected void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        new protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dal.Dispose();
                }
            }

            this.disposed = true;
        }

        # endregion
    }
}