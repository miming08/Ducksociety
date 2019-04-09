using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ducksociety.Controllers
{
    public class DuckstuffController : Controller
    {
        // GET: Duckstuff
        public ActionResult Index()
        {
            return View("~/Views/Duckstuff/Duckstuff.cshtml");
        }
    }
}