using System.Web;
using System.Web.Mvc;

namespace firstMVC
{
    //TODO:定义全局actionfilter的地方
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}