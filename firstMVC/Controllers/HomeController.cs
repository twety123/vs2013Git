using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstMVC.Controllers
{
    public class HomeController : Controller//所有的控制器必须继承controller类,或者icontroller接口
    {
        public ActionResult Index()
        {
            ViewBag.Message = "修改此处的模版，以快速启动你的mvc4应用程序.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序的说明页.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页.";

            return View();
        }
    }
}
