using System.Web.Mvc;
using SoftRouting;


namespace SoftRouting.Tests.Areas.Main {

    public class MainAreaRegistration : AreaRegistration {
        public override string AreaName => "Main";

        public override void RegisterArea(AreaRegistrationContext context) {

            context.WithController("Home")
                .MapIndexPage("index")
                .AutoMap();



        }
    }
}
