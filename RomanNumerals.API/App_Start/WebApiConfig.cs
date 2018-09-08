using RomanNumerals.API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RomanNumerals.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // XML Response delete, only JSON Response
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            // Added model state filters.
            config.Filters.Add(new ValidateModelAttribute());
            config.Filters.Add(new CheckModelForNullAttribute());


            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
