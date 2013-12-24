using System.Web.Http;
using System.Web.Http.Filters;
using CodeArt.WebApi.Attributes.ExceptionHandlingAttribute;

namespace CodeArt.WebApi.App_Start
{
    public class FilterConfig
    {
        public static void RegisterFilters(HttpFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute());
            filters.Add(new ExceptionHandlerAttribute());
        }
    }
}