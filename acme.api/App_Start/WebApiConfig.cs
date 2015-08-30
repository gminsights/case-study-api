using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace acme.api.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // TO enable CORS 
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // default root mapping
            config.Routes.MapHttpRoute(
               name: "JobsApi",
               routeTemplate: "",
               defaults: new { controller = "Jobs", id = RouteParameter.Optional }
           );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}