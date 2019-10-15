using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Controllers
{
    public class PagoController : Controller
    {
        private readonly IRepositorioInmueble repoInmueble;
        private readonly IRepositorio<Inquilino> repoInquilino;
        private readonly IRepositorio<Alquiler> repoAlquiler;
        private readonly IRepositorio<Pago> repoPago;

        public PagoController(IRepositorioInmueble repoInmueble, IRepositorio<Inquilino> repoInquilino, IRepositorio<Alquiler> repoAlquiler, IRepositorio<Pago> repoPago)
        {
            this.repoInmueble = repoInmueble;
            this.repoInquilino = repoInquilino;
            this.repoAlquiler = repoAlquiler;
            this.repoPago = repoPago;
        }

        // GET: Pago
        public ActionResult Index()
        {
            var pagos = repoPago.ObtenerTodos();
            return View(pagos);
        }

        // GET: Pago/Details/5
        public ActionResult Details(int id)
        {
            var pagos = repoPago.ObtenerPorId(id);
            return View(pagos);
        }

        // GET: Pago/Create
        public ActionResult Create()
        {
            ViewBag.Inmuebles = repoInmueble.ObtenerTodos();
            ViewBag.Inquilinos = repoInquilino.ObtenerTodos();
            ViewBag.Alquileres = repoAlquiler.ObtenerTodos();
            return View();
        }

        // POST: Pago/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pago pago)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repoPago.Alta(pago);
                    TempData["id"] = pago.IdAlquiler;
                    TempData["Mensaje"] = "Se Creo el contrato de Alquiler con exito";
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

        // GET: Pago/Edit/5
        public ActionResult Edit(int id)
        {
            var pago = repoPago.ObtenerPorId(id);
            return View(pago);
        }

        // POST: Pago/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pago/Delete/5
        public ActionResult Delete(int id)
        {
            var pago = repoPago.ObtenerPorId(id);
            return View(pago);
        }

        // POST: Pago/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}