using System;
using System.Web.Mvc;

/*DevExpress.Xpf.Core.vXX.Y.dll*/
using DevExpress.Data.Linq;
/*DevExpress.Xpf.Core.vXX.Y.dll*/

namespace E3252_CS.Controllers {
    public class ServerModeEFController : Controller {
        public ActionResult IndexEF() {
            return View(GetEntityServerModeSource());
        }
        public ActionResult GridViewPartialEF() {
            return PartialView(GetEntityServerModeSource());
        }
        private EntityServerModeSource GetEntityServerModeSource() {
            EntityServerModeSource esms = new EntityServerModeSource();
            esms.KeyExpression = "ProductID";
            esms.QueryableSource = new NorthwindEntities().Products;

            return esms;
        }
    }
}