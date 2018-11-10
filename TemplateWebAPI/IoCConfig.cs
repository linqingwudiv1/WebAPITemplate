using AuditSystemBusinessDLL.Helper.Log;
using Autofac;
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

            // Register your Web API controllers.
            var assemble_web = typeof(WebApiApplication).Assembly;
            builder.RegisterApiControllers(assemble_web);

            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();
            // 注册
            builder.Register(c => new NLogHelper()).As<ILogHelper>().InstancePerRequest();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

    }
}