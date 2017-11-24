using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RedSteakServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // lowerCase (camelCase) results
            // RedSteak web aplication uses camelCase in classes
            // -> convertion from json response --> 
            GlobalConfiguration.Configuration.Formatters
                                              .JsonFormatter
                                              .SerializerSettings
                                              .ContractResolver = new CamelCasePropertyNamesContractResolver();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
