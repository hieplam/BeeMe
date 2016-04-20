using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using SeeMe.Ioc;
using SeeMe.Repositories.DomainModels;
using SeeMe.Repositories.Interfaces;

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
            var assembly = typeof (RepositoryModule).Assembly;

            builder.RegisterAssemblyModules(assembly);

            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IRepository<Artist>>();
            }
        }
    }
}