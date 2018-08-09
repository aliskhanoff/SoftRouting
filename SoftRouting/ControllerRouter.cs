///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

namespace SoftRouting {

    public sealed class ControllerRouter : IControllerRouter {

        private readonly string controllerName;
        private readonly string areaName;

        private IActionRouter router;

        public ControllerRouter(string controllerName, string areaName = null) {
            this.controllerName = controllerName;
            this.areaName = areaName;

            //if area mode is enabled, the use areas
            if (!string.IsNullOrEmpty(areaName) && !string.IsNullOrWhiteSpace(areaName)) router = new ActionRouter(controllerName, areaName);

            //else use only controller mapping
            else router = new ActionRouter(controllerName);
        }


        public IActionRouter AutoMap() {
            return router.AutoMap();
        }

        public IActionRouter AutoMap(string prefix) {
            return router.AutoMap(prefix);
        }

        public IActionRouter Map(string actionName) {
            return router.Map(actionName);
        }

        public IActionRouter Map(string actionName, string url) {
            return router.Map(actionName, url);
        }

        public IActionRouter Map(string actionName, string url, object constraint) {
            return router.Map(actionName, url, constraint);
        }

        public IActionRouter MapFullRoute(string actionName, string urlExpression, object constraint= null) {
            return router.MapFullRoute(actionName, urlExpression, constraint);
        }

        public IActionRouter MapFullRoute(string actionName, string urlExpression, object constraints, params string[] namespaces) {
            return router.MapFullRoute(actionName, urlExpression, constraints, namespaces);
        }

        public IActionRouter MapIndexPage(string actionName) {
            return router.MapIndexPage(actionName);
        }


    }
}
