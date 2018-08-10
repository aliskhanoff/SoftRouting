///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using System.Web.Mvc;
using System.Web.Routing;

namespace SoftRouting {

    public static class SoftRouteExtentions {
        
        /// <summary>
        /// Map to area
        /// </summary>
        /// <param name="areaName">Area name which you need to map</param>
        /// <returns>IAreaRouter</returns>
        public static IAreaRouter InArea(this RouteCollection routes, string areaName) {
            return new AreaRouter(areaName);
        }
        
        /// <summary>
        /// Map controller without Area
        /// </summary>
        /// <param name="controllerName">Name of controller to map</param>
        public static IControllerRouter WithController(this RouteCollection routes, string controllerName) {
            return new ControllerRouter(controllerName);
        }

        /// <summary>
        /// Extention method for AreaRegistrationContext class
        /// </summary>
        /// <param name="context">AreaRegistration context</param>
        /// <param name="controllerName">Name of controller</param>
        /// <returns>IControllerRouter interface</returns>
        public static IControllerRouter WithController(this AreaRegistrationContext context, string controllerName) {
            return new ControllerRouter(controllerName, context.AreaName);
        }


        

    }
}
