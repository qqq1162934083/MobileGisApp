using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Space()
        {
            PersonViewModel person = new PersonViewModel
            {
                Name = "刘华栋",
                Age = 19,
                PhoneNumber = "0000-0000",
                SelfIntroduction = "快创建你的个人信息加入我吧"
            };
            return View(person);
        }
    }
}