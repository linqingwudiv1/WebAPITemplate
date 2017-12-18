﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuditSystemWebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "TemplateWebAPI 主页";
            return Redirect("/swagger/ui/index");
        }
    }
}