using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using SoftRouting.Tests.Areas.Accounts.Controllers;
using SoftRouting.Tests.Areas.Main.Controllers;
using System.Web.Routing;

namespace SoftRouting.Tests.Tests {

    [TestClass]
    public class TestSwitchers {


        [TestMethod]
        public void TryChangeAreaInActionRouting() {

            RouteTable.Routes.InArea("Main")
                            .WithController("Home")
                            .MapIndexPage("index")
                            .AutoMap()

                            //jump to another area
                            .SwithArea("Account")
                            .WithController("Login")
                                .AutoMap("account"); //automap all actions with "account" prefix ({prefix}/login; {prefix}/logout)


            "~/".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());

            "~/account/login".Route().ShouldMapTo<LoginController>(x => x.Login());
            "~/account/logout".Route().ShouldMapTo<LoginController>(x => x.Logout());
        }


        [TestMethod]
        public void TryChangeControllerInActionRouting() {


            RouteTable.Routes.InArea("Main")
                        .WithController("Home")
                        .MapIndexPage("index")
                        .AutoMap()
                          
                        .SwithController("Products")
                            .Map("GetProduct", "product/{id}", new { id = "\\d+" }); //automap all actions with "account" prefix ({prefix}/login; {prefix}/logout)


            "~/".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());


            "~/product/134".Route().ShouldMapTo<ProductsController>(x => x.GetProduct(134));

        }
    }
}
