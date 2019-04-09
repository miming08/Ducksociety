using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ducksociety.Controllers
{
    public class VinztoreController : Controller
    {
        // GET: Vinztore
        public ActionResult Index()
        {
            return View("~/Views/Vinztore/Vinztore.cshtml");
        }
    }
}