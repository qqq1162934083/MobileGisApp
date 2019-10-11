using DAL.DAO.WebGeneralDBDao;
using Domain.DBModel.WebGeneralDB;
using Domain.ViewModel;
using Newtonsoft.Json.Linq;
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
        public JsonResult AccountLogin(string email, string password)
        {
            Account account = AccountDao.SelectByEmail(email);
            if (account == null)
            {
                var result = new
                {
                    status = false,
                    message = "账号不存在"
                };
                return Json(result);
            }
            else if(account.Password==password)
            {
                var result = new
                {
                    status = true,
                    message = "登录成功"
                };
                return Json(result);
            }
            else
            {
                var result = new
                {
                    status = false,
                    message = "密码错误"
                };
                return Json(result);
            }
        }
    }
}