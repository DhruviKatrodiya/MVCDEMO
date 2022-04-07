using System.Web;
using System.Web.Mvc;

namespace MVCEntityFrameAppCS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
