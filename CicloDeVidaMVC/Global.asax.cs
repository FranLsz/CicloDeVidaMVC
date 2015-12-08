using System;
using System.CodeDom;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;

namespace CicloDeVidaMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }

        protected void Application_End()
        {

            Console.WriteLine("Se acabó");

        }

    }
}
