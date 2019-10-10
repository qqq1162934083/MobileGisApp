using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileGisApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            About about = new About
            {
                Producer = "刘华栋",
                Address = "湖南省-湘潭市-湖南科技大学",
                Phone = "19967252909"
            };
            return View(about);
        }
    }
}