using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyectoInmobiliaria.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoInmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AlquilerController : ControllerBase
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public AlquilerController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        // GET: api/Contrato
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                var contratosByPropietario = contexto.Alquileres
                .Include(i => i.inquilino)
                .Include(e => e.casa)
                .ThenInclude(p => p.Duenio)
                .Where(x => x.casa.Duenio.Email == usuario);
                return Ok(contratosByPropietario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET: api/Contrato/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var usuario = User.Identity.Name;
                var contratoById = contexto.Alquileres
                .Include(i => i.inquilino)
                .Include(e => e.casa)
                .ThenInclude(p => p.Duenio)
                .Where(x => x.casa.Duenio.Email == usuario && x.IdAlquiler == id);
                return Ok(contratoById);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST: api/Contrato
        [HttpPost]
        public async Task<IActionResult> Post(Alquiler entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Alquileres.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdAlquiler }, entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Contrato/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Alquiler entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    entidad.IdAlquiler = id;
                    contexto.Alquileres.Update(entidad);
                    contexto.SaveChanges();
                    return Ok(entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entidad = contexto.Alquileres.FirstOrDefault(x => x.IdAlquiler == id);

                if (entidad != null)
                {
                    //entidad.EstadoContrato = 0;
                    //contexto.Contratos.Update(entidad);
                    contexto.Alquileres.Remove(entidad);
                    contexto.SaveChanges();
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
