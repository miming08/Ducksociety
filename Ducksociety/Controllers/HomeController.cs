using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ducksociety.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Trench Trench Trench";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trench Trench Trench";

            return View();
        }

        public ActionResult Vinztore()
        {
            ViewBag.Message = "Trench Trench Trench";

            return View();
        }
    }
}