using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public abstract class RepositorioBase
    {
        protected readonly IConfiguration configuration;
        protected readonly string connectionStrings;

        protected RepositorioBase(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionStrings = configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
