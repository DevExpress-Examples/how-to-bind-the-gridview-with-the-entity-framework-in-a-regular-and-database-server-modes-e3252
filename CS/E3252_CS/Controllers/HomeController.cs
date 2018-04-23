using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace E3252_CS.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View("GridView");
        }
        public ActionResult GridViewPartialRazor() {
            return PartialView();
        }
        public ActionResult GridViewPartialASPX() {
            return PartialView();
        }
    }
}