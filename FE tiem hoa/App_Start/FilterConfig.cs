using System.Web;
using System.Web.Mvc;

namespace FE_tiem_hoa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
