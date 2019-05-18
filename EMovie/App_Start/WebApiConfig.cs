using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EMovie
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var camelsetting = config.Formatters.JsonFormatter.SerializerSettings;
            camelsetting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            camelsetting.Formatting = Formatting.Indented;


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
