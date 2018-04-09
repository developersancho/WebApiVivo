using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApiVivo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            /*Response as default json format
     * example (http://localhost:9090/WebApp/api/user/)
     */
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            /*Response as json format depend on request type
             * http://localhost:9090/WebApp/api/user/?type=json
             */
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
            new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));

            /*Response as xml format depend on request type
             * http://localhost:9090/WebApp/api/user/?type=xml
             */
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(
            new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
