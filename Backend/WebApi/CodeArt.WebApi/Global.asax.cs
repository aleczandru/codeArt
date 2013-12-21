using System.Web;
using System.Web.Http;
using CodeArt.WebApi.App_Start;

namespace CodeArt.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterFilters(GlobalConfiguration.Configuration.Filters);
            MapperConfig.RegisterMappings();
        }
    }
}
