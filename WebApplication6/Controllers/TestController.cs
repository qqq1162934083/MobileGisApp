﻿using Domain.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{ 
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View("Result");
        }
    }
}