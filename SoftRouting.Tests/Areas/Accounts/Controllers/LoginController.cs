using System.Web.Mvc;

namespace SoftRouting.Tests.Areas.Accounts.Controllers {

    public class LoginController: Controller {

        public LoginController() {

        }


        [HttpGet]
        public ActionResult Login() {
            return Content("this is login page");
        }


        [HttpGet]
        public ActionResult Logout() {
            return Content("this is logout page. Are you shure you want logout.");
        }



    }
}
