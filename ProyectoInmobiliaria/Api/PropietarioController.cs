using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProyectoInmobiliaria.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoInmobiliaria.Api
{
    [Route("api/[controller]")]
    public class PropietarioController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public PropietarioController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                return Ok(contexto.Propietarios.SingleOrDefault(x => x.Email == usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }            
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                 
                return Ok(contexto.Propietarios.SingleOrDefault(x => x.IdPropietario == id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Propietario propietario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    propietario.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                password: propietario.Password,
                                                salt: System.Text.Encoding.ASCII.GetBytes("SALADA"),
                                                prf: KeyDerivationPrf.HMACSHA1,
                                                iterationCount: 1000,
                                                numBytesRequested: 256 / 8));
                    contexto.Propietarios.Add(propietario);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = propietario.IdPropietario }, propietario);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Propietario propietario)
        {
            propietario.IdPropietario = id;
            contexto.Propietarios.Update(propietario);
            contexto.SaveChanges();
            return Ok(propietario);
            try
            {
                //edita solo el propietario logeado
                if (ModelState.IsValid && contexto.Propietarios.AsNoTracking().SingleOrDefault(p => p.IdPropietario == id && p.Email == User.Identity.Name) != null)
                {
                    propietario.IdPropietario = id;
                    propietario.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                password: propietario.Password,
                                                salt: System.Text.Encoding.ASCII.GetBytes("SALADA"),
                                                prf: KeyDerivationPrf.HMACSHA1,
                                                iterationCount: 1000,
                                                numBytesRequested: 256 / 8));

                    contexto.Propietarios.Update(propietario);
                    contexto.SaveChanges();
                    return Ok(propietario);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                //Borra solo el propie logeado
                var entidad = contexto.Propietarios.FirstOrDefault(e => e.IdPropietario == id);// && e.Email == User.Identity.Name);
                if (entidad != null)
                {
                    //entidad.EstadoPropietario = 0;
                    contexto.Propietarios.Remove(entidad);
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

        // GET api/<controller>/5
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginView loginView)
        {
            try
            {
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: loginView.Password,
                    salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 1000,
                    numBytesRequested: 256 / 8));
                var p = contexto.Propietarios.FirstOrDefault(x => x.Email == loginView.Email);
                if (p == null || p.Password != hashed)
                {
                    return BadRequest("Nombre de usuario o password incorrecto");
                }
                else
                {
                    var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(config["TokenAuthentication:SecretKey"]));
                    var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, p.Email),
                        new Claim("FullName", p.Nombre + " " + p.Apellido),
                        new Claim(ClaimTypes.Role, "Propietario"),
                    };

                    var token = new JwtSecurityToken(
                        issuer: config["TokenAuthentication:Issuer"],
                        audience: config["TokenAuthentication:Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: credenciales
                    );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
