﻿///created by 0xBADC0DED aka Ramazan
/// 9.08.2018

using System.Web.Mvc;

namespace SoftRouting.Tests.Controllers {

    public class ProductsController: Controller {

            public ActionResult GetProduct(uint id) {
                return Content("this is product: " + id);
            }
        
    }
}
