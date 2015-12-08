using System.Web.Mvc;
using CicloDeVidaMVC.Filters;
using CicloDeVidaMVC.Models;

namespace CicloDeVidaMVC.Controllers
{
    //Home Controller
    public class HomeController : Controller
    {
        [InyectorResponse]
        public ActionResult Index()
        {
            ViewBag.cabecera = "Vista index de Home";

            return View();
        }

        public ActionResult Detalle(int id)
        {
            ViewBag.cabecera = "Vista detalle de Home";
            ViewBag.idUsuario = id;

            var usuario = new Usuario()
            {
                Nombre = "Francisco",
                Apellidos = "López Sánchez",
                Edad = 20,
                Pais = "España"
            };

            // Envio de ese modelo a la vista
            return View(usuario);
        }
    }
}