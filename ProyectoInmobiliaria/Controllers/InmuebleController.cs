using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Controllers
{
    public class InmuebleController : Controller
    {
        
        private readonly IRepositorioInmueble repo;
        private readonly IRepositorioPropietario repoPropietario;
        public InmuebleController(IRepositorioInmueble repositorio, IRepositorioPropietario repoPropietrio)
        {
            this.repo = repositorio;
            this.repoPropietario = repoPropietrio;
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inmueble
        public ActionResult Index()
        {
            var lista = repo.ObtenerTodos();
            if (TempData.ContainsKey("Id"))
                ViewBag.Id = TempData["Id"];
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            return View(lista);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inmueble/Details/5
        public ActionResult Details(int id)
        {
            var inmueble = repo.ObtenerPorId(id);
            return View(inmueble);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inmueble/Create
        public ActionResult Create()
        {
            ViewBag.Propietarios = repoPropietario.ObtenerTodos();
            return View();
        }

        [Authorize(Policy = "Administrador")]
        // POST: Inmueble/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inmueble inmueble)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    repo.Alta(inmueble);
                    TempData["id"] = inmueble.IdInmueble;
                    TempData["Mensaje"] = "Se Creo el inmueble con exito";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                ViewBag.StackTrace = e.StackTrace;
                ViewBag.Error = e.Message;
                return View();
            }
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inmueble/Edit/5
        public ActionResult Edit(int id)
        {
            var inmueble = repo.ObtenerPorId(id);
            ViewBag.Propietarios = repoPropietario.ObtenerTodos();
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(inmueble);
        }

        [Authorize(Policy = "Administrador")]
        // POST: Inmueble/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Inmueble inmueble)
        {
            try
            {
                inmueble.IdInmueble = id;
                repo.Modificacion(inmueble);
                TempData["Mensaje"] = "Se Modifico el inmueble con exito";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Propietarios = repoPropietario.ObtenerTodos();
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(inmueble);
            }
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inmueble/Delete/5
        public ActionResult Delete(int id)
        {
            var inmueble = repo.ObtenerPorId(id);
           
            return View(inmueble);
        }

        [Authorize(Policy = "Administrador")]
        // POST: Inmueble/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Inmueble inmueble)
        {
            try
            {
                repo.Baja(id);
                TempData["Mensaje"] = "Eliminación realizada correctamente";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(inmueble);
            }
        }
    }
}