using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace firstMVC
{
    public class RouteConfig
    {
        //todo:定义网址路由的地方
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",//路由名称
                url: "{controller}/{action}/{id}",//地址对应规则
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//设置路由默认值
            );
        }
    }
}