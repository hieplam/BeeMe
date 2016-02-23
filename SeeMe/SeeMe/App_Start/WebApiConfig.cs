using System.Web.Http;
using System.Web.Http.Cors;
using SeeMe.Utilitiis;

namespace SeeMe
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("HomeApi",
                "_api/{controller}/{fileName}",
                defaults: new {fileName = RouteParameter.Optional});
            //constraints: new {fileName = new CustomExpressionConstraint(@"/\.(gif|jpg|jpeg|tiff|png)$/i")});
            //constraints: new { fileName = new CustomExpressionConstraint(@"[A-Za-z]{2}") });

            //config.Routes.MapHttpRoute("DefaultApi1", //Route name
            //    "_api/{controller}/{fileName}", //Urls
            //    defaults: new { fileName = RouteParameter.Optional}); //Defaults option
            //new { fileName = @"\w+" }); //Constraints

            //CORS config
            var corsAttributes = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttributes);
        }
    }
}