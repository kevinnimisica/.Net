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
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            var logica = new DepartamentoLogica();
            return View(logica.getListadoDepartamentos());
        }

        // GET: Departamento/Details/5
        public ActionResult Details(int id)
        {
            var logica = new DepartamentoLogica();
            return View(logica.obtenerDept(id));
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(DepartamentoModel dept)
        {
            try
            {
                var logica = new DepartamentoLogica();
                logica.agregarDept(dept);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            var logica = new DepartamentoLogica();
            return View(logica.obtenerDept(id));
        }

        // POST: Departamento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DepartamentoModel dept)
        {
            try
            {

                var logica = new DepartamentoLogica();
                logica.editarPais(id,dept);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            var logica = new DepartamentoLogica();
            return View(logica.obtenerDept(id));
        }

        // POST: Departamento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, DepartamentoModel dept)
        {
            try
            {
                var logica = new DepartamentoLogica();
                logica.eliminarDept(id, dept);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Ciudades(int id)
        {
            var logCiu = new CiudadLogica();
            return View(logCiu.getCiudadesXDepartamento(id));
        }
    }
}
