using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Rozo.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ConfigureCustomRoutes(config);

            ConfigureDefaultRoutes(config);

            // Configure JSON formatter

            var json = config.Formatters.JsonFormatter;

            // Enable to handle references
            //json.SerializerSettings.PreserveReferencesHandling =
            //    Newtonsoft.Json.PreserveReferencesHandling.Objects;

            // Enable not to handle references
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.None;

            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            json.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }

        private static void ConfigureDefaultRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi1_0",
                routeTemplate: "api1.0/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApiWithoutApiPrefix",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void ConfigureCustomRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "ProvidedAnswerApi",
                routeTemplate: "api/provided-answers/{id}",
                defaults: new { controller = "ProvidedAnswer", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ProvidedAnswerApi1_0",
                routeTemplate: "api1.0/provided-answers/{id}",
                defaults: new { controller = "ProvidedAnswer", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ProvidedAnswerApiWithoutApiPrefix",
                routeTemplate: "provided-answers/{id}",
                defaults: new { controller = "ProvidedAnswer", id = RouteParameter.Optional }
            );
        }
    }
}
