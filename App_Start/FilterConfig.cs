using System.Web;
using System.Web.Mvc;

namespace conroy_mis4200_sd2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
