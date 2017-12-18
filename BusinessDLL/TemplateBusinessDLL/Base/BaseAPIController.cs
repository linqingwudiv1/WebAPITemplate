using AuditSystemBusinessDLL.Static.Business;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace AuditSystemBusinessDLL.Base
{
    /// <summary>
    /// 简单业务可用
    /// </summary>
    abstract public class BaseAPIController : ApiController
    {
        public BaseAPIController() 
            :base()
        {
        }

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            if (controllerContext.Request.Properties.ContainsKey("MS_HttpContext"))
            {
                var address = ((HttpContextWrapper)controllerContext.Request.Properties["MS_HttpContext"]).Request.UserHostAddress;

            }

            base.Initialize(controllerContext);
        }
    }


    /// <summary>
    /// 帮助器业务
    /// </summary>
    /// <typeparam name="BusinessAPI"></typeparam>
    abstract public class BaseAPIController<BusinessAPI> : ApiController
            where BusinessAPI: BusinessAPI_Base, new()
           
    {
        protected BusinessAPI APIHelper { get; private set; }
        public BaseAPIController() 
            :base()
        {
            APIHelper = new BusinessAPI();
        }
    }


}
