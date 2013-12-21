using System.Web.Http;
using System.Web.Http.Filters;

namespace CodeArt.WebApi.App_Start
{
    public class FilterConfig
    {
        public static void RegisterFilters(HttpFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute());
        }
    }
}