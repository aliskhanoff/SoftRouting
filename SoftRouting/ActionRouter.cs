///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using System.Web.Mvc;
using System.Web.Routing;

namespace SoftRouting {

    public class ActionRouter : IActionRouter {

        private readonly string controllerName;
        private readonly string areaName;

        bool isAreaAllowed = false;

        public ActionRouter(string controllerName) {
            this.controllerName = controllerName;
        }

        public ActionRouter(string controllerName, string areaName) {
            this.controllerName = controllerName;
            this.areaName = areaName;

            if (!string.IsNullOrEmpty(areaName) && !string.IsNullOrWhiteSpace(areaName)) isAreaAllowed = true;

        }

        public IActionRouter AutoMap() {

            RouteTable.Routes.MapRoute(null, "{action}", new {
                controller = controllerName
            });

            return this;
        }

        public IActionRouter AutoMap(string prefix) {

            if (string.IsNullOrEmpty(prefix)) return AutoMap();

            RouteTable.Routes.MapRoute(null, string.Format("{0}/{1}", prefix.Trim('/'), "{action}"), new {
                controller = controllerName
            });

            return this;
        }

        public IActionRouter Map(string actionName) {
            return MapFullRoute(actionName, actionName, null);
        }

        public IActionRouter Map(string actionName, string url) {
            return MapFullRoute(actionName, url, null);
        }

        public IActionRouter Map(string actionName, string urlExpression, object constraint) {
            return MapFullRoute(actionName, urlExpression, constraint, null);
        }

        public IActionRouter MapFullRoute(string actionName, string urlExpression, object constraints = null) {
            return MapFullRoute(actionName, urlExpression, constraints, null);
        }

        public IActionRouter MapFullRoute(string actionName, string urlExpression, object constraints, params string[] namespaces) {

            var route = RouteTable.Routes.MapRoute(null, urlExpression, new {
                controller = controllerName,
                action = actionName
            }, constraints, namespaces);

            if (isAreaAllowed) route.DataTokens[DataTokens.AREA_TOKEN] = areaName;
            if (namespaces != null && namespaces.Length > 0) route.DataTokens[DataTokens.NAMESPACE_TOKEN] = true;

            return this;
        }

        public IActionRouter MapIndexPage(string actionName) {
            return this.MapFullRoute(actionName, string.Empty);
        }

        public IAreaRouter SwithArea(string areaName) {
            return new AreaRouter(areaName);
        }

        public IControllerRouter SwithController(string controllerName) {
            return new ControllerRouter(controllerName, areaName);
        }


    }
}
