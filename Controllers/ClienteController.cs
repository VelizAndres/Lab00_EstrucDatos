using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab00_AndresVeliz.Herramientas;
using Lab00_AndresVeliz.Models;

namespace Lab00_AndresVeliz.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Inicio()
        {
            return View(Almacen.Instance.ClientesMList);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult OrdenarName()
        {
            Ordenamiento(true);
             Inicio();
            return View("Inicio");
        }
        public ActionResult OrdenarLast()
        {
            Ordenamiento(false);
            Inicio();
            return View("Inicio");
        }

        // POST: Cliente/Create
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
                    return RedirectToAction("Inicio");
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

        public void Ordenamiento(bool _name)
        {
            for (int i = 0; i < Almacen.Instance.ClientesMList.Count; i++)
            {
                for (int j = i + 1; j < Almacen.Instance.ClientesMList.Count; j++)
                {
                    if (_name)
                    {   
                        string text1 = Almacen.Instance.ClientesMList[i].Nombre.ToLower();
                        string text2 = Almacen.Instance.ClientesMList[j].Nombre.ToLower();
                        if ((text1.CompareTo(text2)) >= 0)
                        {
                            ClienteModel temp = Almacen.Instance.ClientesMList[i];
                            Almacen.Instance.ClientesMList[i] = Almacen.Instance.ClientesMList[j];
                            Almacen.Instance.ClientesMList[j] = temp;
                        }
                    }
                    else
                    {
                        string text1 = Almacen.Instance.ClientesMList[i].Apellido.ToLower();
                        string text2 = Almacen.Instance.ClientesMList[j].Apellido.ToLower();
                        if ((text1.CompareTo(text2)) >= 0)
                        {
                            ClienteModel temp = Almacen.Instance.ClientesMList[i];
                            Almacen.Instance.ClientesMList[i] = Almacen.Instance.ClientesMList[j];
                            Almacen.Instance.ClientesMList[j] = temp;
                        }
                    }
                 }
            }





        }
    }
}