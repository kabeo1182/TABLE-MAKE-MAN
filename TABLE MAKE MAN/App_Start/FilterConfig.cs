using System.Web;
using System.Web.Mvc;

namespace TABLE_MAKE_MAN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
