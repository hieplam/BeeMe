﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using SeeMe.Ioc;
using SeeMe.Services.Interfaces;

namespace SeeMe
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterAutoFac();
        }

        private void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            var repositoryAssembly = typeof (RepositoryModule).Assembly;
            var serviceAssembly = typeof (ServiceModule).Assembly;

            builder.RegisterAssemblyModules(repositoryAssembly);
            builder.RegisterAssemblyModules(serviceAssembly);

            builder.Build();
        }
    }
}