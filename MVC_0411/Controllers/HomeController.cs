using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_0411.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "關魚大內容啦啦啦";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "聯絡大內容啦啦啦";

            return View();
        }
        public ActionResult Progress()
        {
            ViewBag.Message = "病程大內容啦啦啦";

            return View();
        }
        public ActionResult html5()
        {
            ViewBag.Message = "啥";

            return View();
        }
    }
}