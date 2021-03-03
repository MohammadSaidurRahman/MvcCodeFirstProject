using System.Web;
using System.Web.Mvc;

namespace MvcCodeFirstProject_Sayed
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
