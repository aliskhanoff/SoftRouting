///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

namespace SoftRouting {

    public interface IRouter {

        /// <summary>
        /// Mapping route with all params
        /// </summary>
        /// <param name="actionName">Action name in Controller</param>
        /// <param name="urlExpression">Url of this action</param>
        /// <param name="constraint">Route constraints</param>
        /// <returns>IActionRouter interface</returns>
        IActionRouter MapFullRoute(string actionName, string urlExpression, object constraint = null);

        /// <summary>
        /// Mapping route with all params and Namespace Fallback
        /// </summary>
        /// <param name="actionName">Action name in Controller</param>
        /// <param name="urlExpression">Url of this action</param>
        /// <param name="constraint">Route constraints</param>
        /// <param name="namespaces">Namespaces of the route</param>
        /// <returns>IActionRouter interface</returns>
        IActionRouter MapFullRoute(string actionName, string urlExpression, object constraint, params string[] namespaces);

        /// <summary>
        /// Method, which mapping all actions in Controller automatically
        /// Same, with RouteTable.Routes.MapRoute(null, "action", new { controller = "controller", action = "{action}" })
        /// </summary>
        /// <returns>IActionRouter</returns>
        IActionRouter AutoMap();

        /// <summary>
        /// Method, which mapping all actions in Controller automatically
        /// Same, with RouteTable.Routes.MapRoute(null, "{prefix}/action", new { controller = "controller", action = "{action}" })
        /// </summary>
        /// <param name="prefix">prefix of url (prefix/action)</param>
        /// <returns>IActionRouter</returns>
        IActionRouter AutoMap(string prefix);

        /// <summary>
        /// Mapping index page
        /// </summary>
        /// <param name="actionName">Name of action</param>
        /// <returns>IActionRouter</returns>
        IActionRouter MapIndexPage(string actionName);

        /// <summary>
        /// Map to action. Url of action has same name
        /// </summary>
        /// <param name="actionName">Name of Controller action</param>
        /// <returns>IActionRouter</returns>
        IActionRouter Map(string actionName);

        /// <summary>
        /// Map to action
        /// </summary>
        /// <param name="actionName">Name of Controller action</param>        
        /// <param name="urlExpression">Url of action</param>
        /// <returns>IActionRouter</returns>
        IActionRouter Map(string actionName, string urlExpression);

        /// <summary>
        ///  Map to action with constraint
        /// </summary>
        /// <param name="actionName">Name of Controller action</param>
        /// <param name="urlExpression">Url of action</param>
        /// <param name="constraint">Action constraint</param>
        /// <returns>IActionRouter</returns>
        IActionRouter Map(string actionName, string urlExpression, object constraint);

    }


}
