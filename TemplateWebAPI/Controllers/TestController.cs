using AuditSystemBusinessDLL.Helper;
using AuditSystemBusinessDLL.Helper.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuditSystemWebAPI.Controllers
{
    /// <summary>
    /// 测试
    /// </summary>
    public class TestController : ApiController
    {
        private readonly ILogHelper logHelper = null;
        /// <summary>
        /// 
        /// </summary>
        public TestController(ILogHelper _logHelper)
        {
            logHelper = _logHelper;
        }

        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public string HelloWebAPI()
        {
            return "Hello WebAPI";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [HttpGet]
        public bool NLog_Test(string info = "")
        {
            logHelper.WriteInfo("info : " + info);
            logHelper.WriteError("Error : " + info);
            logHelper.WriteWaring("Waring : " + info);
            return true;
        }
    }
}