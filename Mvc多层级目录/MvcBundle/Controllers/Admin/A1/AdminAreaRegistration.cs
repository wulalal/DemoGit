using System.Web.Mvc;

namespace MvcBundle.Controllers.Admin.A1
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin/A1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/A1/{controller}/{action}/{id}",
                new { controller = "AdminMange", action = "Index", id = UrlParameter.Optional },
                new string[] { "MvcBundle.Controllers.Admin.A1" }
            );
        }
    }
}
