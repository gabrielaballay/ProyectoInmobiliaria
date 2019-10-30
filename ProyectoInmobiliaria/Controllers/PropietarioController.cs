using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Controllers
{
    public class PropietarioController : Controller
    {
        IRepositorio<Propietario> repo;
        private readonly IConfiguration config;
        public PropietarioController(IRepositorio<Propietario> repositorio, IConfiguration config)
        {
            repo = repositorio;
            this.config = config;
        }

        [Authorize(Policy = "Administrador")]
        // GET: Propietario
        public ActionResult Index()
        {
            var propietarios = repo.ObtenerTodos();
            if (TempData.ContainsKey("MensajeData"))
            {
                ViewBag.Mensaje = TempData["MensajeData"].ToString();
            }
            return View(propietarios);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Propietario/Details/5
        public ActionResult Details(int id)
        {
            Propietario p = repo.ObtenerPorId(id);
            return View(p);
        }

        [Authorize(Policy = "Administrador")]
        // GET: Propietario/Create
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "Administrador")]
        // POST: Propietario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Propietario propietario)
        {
            try
            {
                if (ModelState.IsValid && propietario.Password.Length>3)
                {
                    propietario.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: propietario.Password,
                        salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 1000,
                        numBytesRequested: 256 / 8));
                    repo.Alta(propietario);
                    TempData["id"] = propietario.IdPropietario;
                    TempData["MensajeData"] = "Se creo el propietario con exito";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Error al crear un propietario asegurese que todos los campos estan compltos";

                    return View();
                }

                
            }
            catch(Exception e)
            {
                ViewBag.StackTrace = e.StackTrace;
                ViewBag.Error = e.Message;
                ViewBag.Error = "Error al crear un propietario asegurese que todos los campos estan compltos";

                return View();
            }
        }

        [Authorize(Policy = "Administrador")]
        // GET: Propietario/Edit/5
        public ActionResult Edit(int id)
        {
            Propietario p = repo.ObtenerPorId(id);
            return View(p);
        }

        [Authorize(Policy = "Administrador")]
        // POST: Propietario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Propietario propietario)
        {
            try
            {
                propietario.IdPropietario = id;
                if (ModelState.IsValid)
                {                    
                    repo.Modificacion(propietario);
                    TempData["MensajeData"] = "Se Modifico el propietario con exito";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Prueba";
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
        // GET: Propietario/Delete/5
        public ActionResult Borrar(int id)
        {
            Propietario p = repo.ObtenerPorId(id);
            return View(p);
        }

        [Authorize(Policy = "Administrador")]
        // POST: Propietario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Borrar(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Baja(id);
                    TempData["MensajeData"] = "Se Borro el propietario con exito";
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