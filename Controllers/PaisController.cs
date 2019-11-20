using Logica;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_20266787.Controllers
{
    [Authorize (Roles = "Usuario")]
    public class PaisController : Controller
    {
        // GET: Pais
        public ActionResult Index()
        {
            var logica = new PaisLogica();
            var paises = logica.getListadoPaises();
            return View(paises);
        }

        // GET: Pais/Details/5
        public ActionResult Details(int id)
        {
            var logica = new PaisLogica();
            return View(logica.obtenerPais(id));
        }

        // GET: Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pais/Create
        [HttpPost]
        public ActionResult Create(PaisModel pais)
        {
            try
            {
                var logica = new PaisLogica();
                logica.agregarPais(pais);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pais/Edit/5
        public ActionResult Edit(int id)
        {
            var logicaPais = new PaisLogica();
            return View(logicaPais.obtenerPais(id));
        }

        // POST: Pais/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PaisModel pais)
        {
            try
            {
                var logicaPais = new PaisLogica();
                logicaPais.editarPais(id, pais);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pais/Delete/5
        public ActionResult Delete(int id)
        {
            var logicaPais = new PaisLogica();
            return View(logicaPais.obtenerPais(id));
        }

        // POST: Pais/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PaisModel pais)
        {
            try
            {
                var logicaPais = new PaisLogica();
                logicaPais.eliminarPais(id, pais);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Get: Pais/Departamentos/5
        public ActionResult Departamentos(int id)
        {
            var logDept = new DepartamentoLogica();
            return View(logDept.getDepartamentoXPais(id));
        }
    }
}
