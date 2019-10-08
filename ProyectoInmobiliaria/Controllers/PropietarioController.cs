using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Controllers
{
    public class PropietarioController : Controller
    {
        IRepositorio<Propietario> repo;
        public PropietarioController(IRepositorio<Propietario> repositorio)
        {
            repo = repositorio;
        }
        // GET: Propietario
        public ActionResult Index()
        {
            //Data data = new Data();
            var propietarios = repo.ObtenerTodos();
            return View(propietarios);
        }

        // GET: Propietario/Details/5
        public ActionResult Details(int id)
        {
            Propietario p = repo.ObtenerPorId(id);
            return View(p);
        }

        // GET: Propietario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propietario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Propietario propietario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Alta(propietario);
                    TempData["id"] = propietario.IdPropietario;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

                
            }
            catch(Exception e)
            {
                ViewBag.StackTrace = e.StackTrace;
                ViewBag.Error = e.Message;
                return View();
            }
        }

        // GET: Propietario/Edit/5
        public ActionResult Edit(int id)
        {
            Propietario p = repo.ObtenerPorId(id);
            return View(p);
        }

        // POST: Propietario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Propietario propietario)
        {
            try
            {
                repo.Modificacion(propietario);
                return RedirectToAction(nameof(Index));
               
            }
            catch (Exception e)
            {
                ViewBag.StackTrace = e.StackTrace;
                ViewBag.Error = e.Message;
                return View();
            }
        }

        // GET: Propietario/Delete/5
        public ActionResult Delete(int id)
        {
            Propietario p = repo.ObtenerPorId(id);
            return View(p);
        }

        // POST: Propietario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Baja(id);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
}