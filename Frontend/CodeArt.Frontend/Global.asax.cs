using System;
using System.Web;
using System.Web.Routing;

namespace CodeArt.Frontend
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}