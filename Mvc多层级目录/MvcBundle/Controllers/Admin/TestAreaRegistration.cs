using System.Web.Mvc;

namespace MvcBundle.Controllers.Admin.A1
{
    public class TestAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Test_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "AdminMange", action = "Index", id = UrlParameter.Optional },
                new string[] { "MvcBundle.Controllers.Admin" }
            );
        }
    }
}
