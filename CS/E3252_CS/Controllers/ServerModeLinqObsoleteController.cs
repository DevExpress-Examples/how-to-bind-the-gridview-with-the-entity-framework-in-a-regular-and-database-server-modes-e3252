using System;
using System.Web.Mvc;

namespace E3252_CS.Controllers {
    public class ServerModeLinqObsoleteController : Controller {
        public ActionResult IndexLinqObsolete() {
            return View();
        }
        public ActionResult GridViewPartialLinqObsolete() {
            return PartialView();
        }
    }
}