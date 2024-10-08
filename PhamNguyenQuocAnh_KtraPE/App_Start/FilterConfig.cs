using System.Web;
using System.Web.Mvc;

namespace PhamNguyenQuocAnh_KtraPE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
