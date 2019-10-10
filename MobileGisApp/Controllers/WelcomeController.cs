using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileGisApp.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Wecome
        public ActionResult Index()
        {
            DateTime nowTime = DateTime.Now;
            ViewBag.Greeting = nowTime.Hour < 12 ? "上午好" : "下午好";
            return View();
        }
    }
}