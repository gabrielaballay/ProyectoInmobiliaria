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
    public class InquilinoController : Controller
    {
        IRepositorio<Inquilino> repo;
        public InquilinoController(IRepositorio<Inquilino> repositorio)
        {
            repo = repositorio;
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inquilino
        public ActionResult Index()
        {
            var inquilinos = repo.ObtenerTodos();
            if (TempData.ContainsKey("MensajeData"))
            {
                ViewBag.Mensaje = TempData["MensajeData"].ToString();
            }
            return View(inquilinos);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inquilino/Details/5
        public ActionResult Details(int id)
        {
            var inquilino = repo.ObtenerPorId(id);
            return View(inquilino);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Inquilino/Create
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "Administrador")]
        // POST: Inquilino/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inquilino inquilino)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Alta(inquilino);
                    TempData["id"] = inquilino.IdInquilino;
                    TempData["MensajeData"] = "Se Creo el inquilino con exito";
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
        // GET: Inquilino/Edit/5
        public ActionResult Edit(int id)
        {
            var inquilino = repo.ObtenerPorId(id);
            return View(inquilino);
        }

        [Authorize(Policy = "Administrador")]
        // POST: Inquilino/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Inquilino inquilino)
        {
            try
            {
                if (ModelState.IsValid)
                {                   
                    repo.Modificacion(inquilino);
                    TempData["MensajeData"] = "Se Modifico el inquilino con exito";
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
        // GET: Inquilino/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repo.ObtenerPorId(id));
        }

        [Authorize(Policy = "Administrador")]
        // POST: Inquilino/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Baja(id);
                    TempData["MensajeData"] = "Se Borro el inquilino con exito";
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
    }
}