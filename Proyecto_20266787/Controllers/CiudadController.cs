using Logica;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_20266787.Controllers
{
    [Authorize(Roles = "Usuario")]
    public class CiudadController : Controller
    {
        CiudadLogica logica = new CiudadLogica();
        // GET: Ciudad
        public ActionResult Index()
        {
            
            return View(logica.getListadoCiudades());
        }

        // GET: Ciudad/Details/5
        public ActionResult Details(int id)
        {
            return View(logica.obtenerCiudad(id));
        }

        // GET: Ciudad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ciudad/Create
        [HttpPost]
        public ActionResult Create(CiudadesModel ciudad)
        {
            try
            {
                logica.CreateCiudad(ciudad);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudad/Edit/5
        public ActionResult Edit(int id)
        {
            return View(logica.obtenerCiudad(id));
        }

        // POST: Ciudad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CiudadesModel ciudad)
        {
            try
            {
                logica.editarCiudad(id, ciudad);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudad/Delete/5
        public ActionResult Delete(int id)
        {
            return View(logica.obtenerCiudad(id));
        }

        // POST: Ciudad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CiudadesModel ciudad)
        {
            try
            {
                logica.eliminarCiudad(id, ciudad);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
