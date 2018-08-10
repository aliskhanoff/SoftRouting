using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using SoftRouting.Tests.Areas.Main;
using SoftRouting.Tests.Areas.Main.Controllers;
using System.Web.Mvc;
using System.Web.Routing;

namespace SoftRouting.Tests.Tests {


    [TestClass]
    public class TestAreaRegistrationContextRouting {
        

        [TestMethod]
        public void TryMapRouteOverAreaRegistrationContext() {
            RouteTable.Routes.Clear();

            var context = new AreaRegistrationContext("Main", RouteTable.Routes);
            var areaRegistration = new MainAreaRegistration();

            areaRegistration.RegisterArea(context);


            "~/".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());
        }

        
    }
}
