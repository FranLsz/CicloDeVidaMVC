using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicloDeVidaMVC.Filters
{
    public class InyectorResponseAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br> Filtro: Antes de ejecutar la acción <br>");

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br> Filtro: Despues de que se ejecute la acción <br>");

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br> Filtro: Antes de que se añada el resultado de la vista al Response <br>");

            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br> Filtro: Despues de que se añada el resultado de la vista al Response <br>");

            base.OnResultExecuted(filterContext);
        }
    }
}