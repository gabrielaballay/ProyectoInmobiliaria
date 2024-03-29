﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Controllers
{
    
    public class AlquilerController : Controller
    {
        private readonly IRepositorioInmueble repoInmueble;
        private readonly IRepositorio<Inquilino> repoInquilino;
        private readonly IRepositorio<Alquiler> repo;

        public AlquilerController(IRepositorioInmueble repoInmueble, IRepositorio<Inquilino> repoInquilino, IRepositorio<Alquiler> repo) 
        {
            this.repoInmueble = repoInmueble;
            this.repoInquilino = repoInquilino;
            this.repo = repo;
        }

        [Authorize(Policy = "Administrador")]
        // GET: Alquiler
        public ActionResult Index()
        {
            var alquiler = repo.ObtenerTodos();
            if (TempData.ContainsKey("Id"))
                ViewBag.Id = TempData["Id"];
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            return View(alquiler);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Alquiler/Details/5
        public ActionResult Details(int id)
        {
            var alquiler = repo.ObtenerPorId(id);
            return View(alquiler);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Alquiler/Create
        public ActionResult Create()
        {
            ViewBag.Inmuebles = repoInmueble.ObtenerTodos();
            ViewBag.Inquilinos = repoInquilino.ObtenerTodos();
            return View();
        }

        [Authorize(Policy = "Administrador")]
        // POST: Alquiler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alquiler alquiler)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Alta(alquiler);
                    TempData["id"] = alquiler.IdAlquiler;
                    TempData["Mensaje"] = "Se Creo el contrato de Alquiler con exito";
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
        // GET: Alquiler/Edit/5
        public ActionResult Edit(int id)
        {
            var alquiler = repo.ObtenerPorId(id);
            ViewBag.Inmuebles = repoInmueble.ObtenerTodos();
            ViewBag.Inquilinos = repoInquilino.ObtenerTodos();
           
            return View(alquiler);
        }

        [Authorize(Policy = "Administrador")]
        // POST: Alquiler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Alquiler alquiler)
        {
            try
            {
                alquiler.IdAlquiler = id;
                repo.Modificacion(alquiler);
                TempData["Mensaje"] = "Se edito el Contrato de Alquiler correctamente";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Inmuebles = repoInmueble.ObtenerTodos();
                ViewBag.Inquilinos = repoInquilino.ObtenerTodos();
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(alquiler);
            }
        }

        [Authorize(Policy = "Administrador")]
        // GET: Alquiler/Delete/5
        public ActionResult Delete(int id)
        {
            var alquiler = repo.ObtenerPorId(id);
            return View(alquiler);
        }

        // POST: Alquiler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Alquiler alquiler)
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
                return View(alquiler);
            }
        }
    }
}