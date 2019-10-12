using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileGisApp.Controllers
{
    public class PersonController : Controller
    {
        public static int VisitTimes { get; set; } = 31;
        public static int VisitorVolume { get; set; } = 26;
        public static int AmountOfSupport { get; set; } = 49;

        // GET: Person
        public ActionResult Space()
        {
            VisitTimes++;
            VisitorVolume++;
            AmountOfSupport++;
            ViewBag.VisitTimes = VisitTimes;
            ViewBag.VisitorVolume = VisitorVolume;
            ViewBag.AmountOfSupport = AmountOfSupport;
            PersonViewModel person = new PersonViewModel
            {
                Name = "刘华栋",
                PinyinInitials = "LHD",
                Age = 19,
                PhoneNumber = "15211968411",
                SelfIntroduction = "快创建你的个人信息加入我吧"
            };
            return View(person);
        }

        public ActionResult Contact()
        {
            VisitTimes++;
            VisitorVolume++;
            AmountOfSupport++;
            PersonViewModel person = new PersonViewModel
            {
                Name = "刘华栋",
                PinyinInitials = "LHD",
                Age = 19,
                PhoneNumber = "0000-0000",
                SelfIntroduction = "快创建你的个人信息加入我吧"
            };
            return View(person);
        }
    }
}