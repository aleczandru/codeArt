using System.Web;
using CodeArt.Common.Contracts.Wrappers;

namespace CodeArt.Common.Wrappers
{
    public class HttpContextWrapper : IHttpContextWrapper
    {
        public HttpContext Current
        {
            get
            {
                return HttpContext.Current;
            } 
        }

        public static HttpApplicationState Application
        {
            get
            {
                return HttpContext.Current.Application;
            }
        }
    }
}
