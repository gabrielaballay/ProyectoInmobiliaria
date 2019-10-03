﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public interface IRepositorio<T>
    {
        int Alta(T t);
        int Baja(int id);
        int Modificacion(T t);
        IList<T> ObtenerTodos();
        T ObtenerPorId(int id);
        T ObtenerPorEmail(string email);
    }
}