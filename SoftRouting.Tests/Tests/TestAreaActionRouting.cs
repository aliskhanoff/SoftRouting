///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using SoftRouting.Tests.Areas.Main.Controllers;
using System.Web.Routing;

namespace SoftRouting.Tests.Tests {

    [TestClass]
    public class TestAreaActionRouting {
        
        
        [TestMethod]
        public void TestMapIndexPage() {

            RouteTable.Routes.Clear();

            RouteTable.Routes
                .InArea("Main")
                .WithController("Home")
                .MapIndexPage("index"); //action name => index

            "~/".Route().ShouldMapTo<HomeController>(x => x.Index());
        }

        [TestMethod]
        public void TestAutoMapping() {

            RouteTable.Routes.Clear();

            RouteTable.Routes
                .InArea("Main")
                .WithController("Home")
                .AutoMap(); //action name => index

            "~/index".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());
        }

        [TestMethod]
        public void TestAutoMappingWithUrlPrefix() {

            RouteTable.Routes.Clear();

            RouteTable.Routes
                .InArea("Main")
                .WithController("Home")
                .AutoMap("us"); //url prefix main

            "~/us/index".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/us/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/us/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());
        }


        [TestMethod]
        public void TestMapToActionWithSameName() {

            RouteTable.Routes.Clear();

            RouteTable.Routes

                .InArea("Main")
                    .WithController("Home")
                        .Map("index")
                        .Map("about")
                        .Map("contacts");

            "~/index".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());

        }


        [TestMethod]
        public void TestMapToActionWithUrlExpression() {

            RouteTable.Routes.Clear();

            RouteTable.Routes

                .InArea("Main")
                    .WithController("Home")
                        .Map("index", "home/index")
                        .Map("about", "us/about")
                        .Map("contacts", "us/contacts");

            "~/home/index".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/us/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/us/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());
        }

        [TestMethod]
        public void TestMapToActionWithUrlExpressionAndConstraint() {

            RouteTable.Routes.Clear();

            RouteTable.Routes

                .InArea("Main")
                    .WithController("Products")
                        .Map("getproduct", "products/{id}", new { id = "\\d+" });

            "~/products/45".Route().ShouldMapTo<ProductsController>(x => x.GetProduct(45));
            "~/products/90".Route().ShouldMapTo<ProductsController>(x => x.GetProduct(90));
            
        }

    }
}
