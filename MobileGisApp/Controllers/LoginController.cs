using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileGisApp.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(AccountViewModel account)
        {
            if (ModelState.IsValid&&account.Password.Equals(account.AccountNumber+"+"))
            {
                ViewBag.Greeting = DateTime.Now.Hour < 12 ? "上午好" : "下午好";
                return View("LoginResult", account);
            }
            return View();
        }
    }
}