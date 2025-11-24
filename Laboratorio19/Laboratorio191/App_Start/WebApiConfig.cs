using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


// EDITADO
namespace Laboratorio191
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                // Agregamos {action} a la ruta: Ahora las URLs incluirán el nombre del método
                // LUEGO LE QUITAMOS {action} PARA VOLVER A LA RUTA ORIGINAL Y PODER RETORNAR VALUES
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Configurar JSON para usar camelCase en las propiedades
            var formatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            formatter.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

        }
    }
}
