///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using System.Web.Mvc;

namespace SoftRouting.Tests.Areas.Main.Controllers{

    
    public class HomeController: Controller {

        public HomeController() {

        }

        public ActionResult Index() {
            return Content("index");
        }

        public ActionResult About() {
            return Content("about");
        }

        public ActionResult Contacts() {
            return Content("contacts");
        }
        

    }
}
