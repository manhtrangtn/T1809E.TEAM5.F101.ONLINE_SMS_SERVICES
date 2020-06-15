using System.Web;
using System.Web.Mvc;

namespace T1809E.TEAM5.F101.ONLINE_SMS_SERVICES
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
