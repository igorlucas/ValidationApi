using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //Remove o XML
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);
            //Modifica a identação
            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //Modifica a serialização
            jsonSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RouteApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
