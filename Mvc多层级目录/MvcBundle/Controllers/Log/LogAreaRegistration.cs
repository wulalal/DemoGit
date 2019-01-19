using System.Web.Mvc;

namespace MvcBundle.Areas.Log
{
    public class LogAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Log";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Log_default",
                "Log/{controller}/{action}/{id}",
                new { controller = "LogCus", action = "Index", id = UrlParameter.Optional },
                new string[] { "MvcBundle.Controllers.Log" }
            );
        }
    }
}
