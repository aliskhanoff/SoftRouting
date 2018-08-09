///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftRouting;
using System.Web.Routing;

namespace SoftRouting.Tests.Tests {

    [TestClass]
    public class TestSoftRoutingExtention {

        [TestMethod]
        public void TestGetIAreaInterface() {

            var mainArea = RouteTable.Routes.InArea("Main");
            Assert.IsTrue(mainArea is IAreaRouter);
        }

        [TestMethod]
        public void TestGetIControllerInterface() {

            var mainArea = RouteTable.Routes.WithController("Home");
            Assert.IsTrue(mainArea is IControllerRouter);
        }

    }
}
