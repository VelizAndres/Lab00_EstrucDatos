using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab00_AndresVeliz.Herramientas;
using Lab00_AndresVeliz.Models;

namespace Lab00_AndresVeliz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Clientes";
            return View(Almacen.Instance.ClientesMList);
    
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerda de la aplicación.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto.";

            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Message = "Crear Cliente.";

            return View();
        }




        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var comprador = new ClienteModel
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Descripcion = collection["Descripcion"],
                    Telefono = int.Parse(collection["Telefono"])
                };
                if (comprador.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(comprador);
                }
            }
            catch
            {
                return View();
            }
        }

    }
}