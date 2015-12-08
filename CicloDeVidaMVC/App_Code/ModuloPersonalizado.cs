using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CicloDeVidaMVC
{

    public class ModuloPersonalizado : IHttpModule
    {

        public void Init(HttpApplication app)
        {

            app.BeginRequest += Application_BeginRequest;

            app.EndRequest += Application_EndRequest;

        }

        private void Application_BeginRequest(Object source,
            EventArgs e)
        {
            HttpApplication app = (HttpApplication)source;
            HttpContext context = app.Context;

            context.Response.Write("<br><br><br><h1><font color=blue>" +
                                   "Inicio de la petición" +
                                   "</font></h1><div style='color:blue; font-weight:bold'>______________________________________________________</div>");

            var modulosCargados = app.Modules.AllKeys;
        }

        private void Application_EndRequest(Object source, EventArgs e)
        {
            HttpApplication app = (HttpApplication)source;
            HttpContext context = app.Context;

            context.Response.Write("<div style='color:blue; font-weight:bold'>______________________________________________________</div><h1><font color=blue>" +
                                   "Final de la petición</font></h1>");
        }

        public void Dispose()
        {
        }
    }
}
