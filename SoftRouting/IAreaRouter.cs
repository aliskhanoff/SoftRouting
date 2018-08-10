///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

namespace SoftRouting {

    /// <summary>
    /// Interface using to map Areas
    /// </summary>
    public interface IAreaRouter {

        /// <summary>
        /// Map with controller
        /// </summary>
        /// <param name="name">Name of controller</param>
        /// <returns>IControllerRouter</returns>
        IControllerRouter WithController(string name);
        


    }
}