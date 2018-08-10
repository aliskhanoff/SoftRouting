///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using System.Web.Mvc;

namespace SoftRouting.Tests.Areas.Main.Controllers {

    public class ProductsController: Controller {



        [HttpGet]
        public ActionResult  GetProduct(uint id) {

            return Content("this is product: " + id);
        }

    }
}
