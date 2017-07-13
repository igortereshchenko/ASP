using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Home()
        {
            
            return View();
        }

        public ActionResult PartialView()
        {
            ViewBag.Message = "Call first partial view";
            return View("PartialView");
        }

    }
}
