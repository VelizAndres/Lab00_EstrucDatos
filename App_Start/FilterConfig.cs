using System.Web;
using System.Web.Mvc;

namespace Lab00_AndresVeliz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
