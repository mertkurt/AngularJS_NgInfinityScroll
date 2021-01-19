using System.Web;
using System.Web.Mvc;

namespace AngularJS_NgInfinityScroll
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
