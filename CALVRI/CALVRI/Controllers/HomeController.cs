using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CALVRI.DAL;

using MongoDB.Driver;

namespace CALVRI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 

            return View();
        }

        public ActionResult Notfound()
        {

            return View();
        }

    }
}