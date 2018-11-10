using AuditSystemBusinessDLL.Helper.Log;
using System;
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
        private readonly ILogHelper logHelper;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_logHelper"></param>
        public HomeController(ILogHelper _logHelper)
        {
            this.logHelper = _logHelper;
            logHelper.WriteInfo("hollo controller");
        }
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
