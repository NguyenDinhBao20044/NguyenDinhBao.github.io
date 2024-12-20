using System.Web;
using System.Web.Mvc;

namespace NguyenDinhBao_2122110313
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
