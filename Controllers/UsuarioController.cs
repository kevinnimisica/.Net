using Logica;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_20266787.Controllers
{
    [Authorize(Roles ="Administrador")]
    public class UsuarioController : Controller
    {
        UsuarioLogica logica = new UsuarioLogica();
        // GET: Usuario
        public ActionResult Index()
        {
            return View(logica.getListadoUsuarios());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(string id)
        {
            return View(logica.obtenerUsuario(id));
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(UsuarioModelo usuario)
        {
            try
            {
                logica.agregarUsuario(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(string id)
        {
            return View(logica.obtenerUsuario(id));
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, UsuarioModelo user)
        {
            try
            {
                logica.editarUsuario(id, user);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(string id)
        {
            return View(logica.obtenerUsuario(id));
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
