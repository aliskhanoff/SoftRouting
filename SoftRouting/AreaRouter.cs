///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

namespace SoftRouting {

    public class AreaRouter: IAreaRouter {
        
        private readonly string areaName;

        public AreaRouter(string areaName) {
            this.areaName = areaName;
        }
        
        /// <summary>
        /// Map to controller using controller name
        /// </summary>
        /// <param name="controllerName">Name of controller in Area</param>
        /// <returns>IControllerRouter</returns>
        public IControllerRouter WithController(string controllerName) {
            return new ControllerRouter(controllerName, areaName);
        }



    }
}
