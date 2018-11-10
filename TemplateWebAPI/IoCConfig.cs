using AuditSystemBusinessDLL.Helper.Log;
using AuditSystemBusinessDLL.Model.EF;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AuditSystemWebAPI
{
    /// <summary>
    /// 
    /// </summary>
    public class IoCConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RegisterDependencies()
        {
            #region Create the builder
            var builder = new ContainerBuilder();
            #endregion

            var config = GlobalConfiguration.Configuration;
            var assemble_web = typeof(WebApiApplication).Assembly;

            #region WebAPI
            builder.RegisterApiControllers(assemble_web);
            #endregion

            #region MVC
            builder.RegisterControllers(assemble_web);
            #endregion

            // 注册组件
            builder.Register(c => new NLogHelper()).As<ILogHelper>().InstancePerRequest();
            builder.Register(c => new DBDataHelper()).As<IDataHelper>().InstancePerRequest();
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}