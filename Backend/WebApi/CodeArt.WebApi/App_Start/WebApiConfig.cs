using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using Microsoft.Practices.Unity.WebApi;
using Newtonsoft.Json.Serialization;

namespace CodeArt.WebApi.App_Start
{
    public static class WebApiConfig
    {
        private static IDependencyContainerWrapper dependencyContainer;

        private static IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer = new DependencyContainerWrapper());
            }
        }

        public static void Register(HttpConfiguration config)
        {
            ConfigureDependencyResolver(config);
            ConfigureMediaTypeFormatter(config);
            ConfigureRouting(config);
            ConfigureCrossOriginResourseSharing(config);
        }

        private static void ConfigureRouting(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new {id = RouteParameter.Optional}
                );
        }

        private static void ConfigureDependencyResolver(HttpConfiguration configuration)
        {
            HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] = DependencyContainer;
            DependencyConfig.RegisterDependencies();
            var dependencyContainerInstance = (DependencyContainerWrapper)DependencyContainer;
            configuration.DependencyResolver = new UnityDependencyResolver(dependencyContainerInstance.UnityContainer);

        }

        private static void ConfigureMediaTypeFormatter(HttpConfiguration config)
        {
            config.Formatters
                  .Clear();
            config.Formatters
                  .Add(new JsonMediaTypeFormatter());
            config.Formatters
                  .JsonFormatter
                  .SerializerSettings
                  .ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        private static void ConfigureCrossOriginResourseSharing(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
        }
    }
}
