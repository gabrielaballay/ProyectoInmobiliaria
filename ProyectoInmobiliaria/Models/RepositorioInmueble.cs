using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class RepositorioInmueble : RepositorioBase, IRepositorio<Inmueble>
    {
        public RepositorioInmueble(IConfiguration configuration) : base(configuration) { }
        public int Alta(Inmueble inmueble)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"INSERT INTO Inmueble (Direccion, Uso, Tipo, CantidadHabitaciones,Precio,Estado, IdPropietario)" +
                    $"VALUES ('{inmueble.Direccion}','{inmueble.Uso}','{inmueble.Tipo}',{inmueble.CantidadHabitaciones}," +
                    $"{inmueble.Precio},'{inmueble.Estado}',{inmueble.IdPropietario})";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    command.CommandText = "SELECT SCOPE_IDENTITY()";
                    var id = command.ExecuteScalar();
                    inmueble.IdInmueble = Convert.ToInt32(id);
                    connection.Close();
                }

            }
            return res;
        }

        public int Baja(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificacion(Inmueble t)
        {
            throw new NotImplementedException();
        }

        public Inmueble ObtenerPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Inmueble ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Inmueble> ObtenerTodos()
        {
            IList<Inmueble> res = new List<Inmueble>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT Direccion, Uso, Tipo, CantidadHabitaciones,Precio,Estado, IdPropietario FROM Inmuebles";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Propietario p = new Propietario
                        { IdPropietario = Convert.ToInt32(reader["IdPropietario"])};
                        Inmueble inm = new Inmueble
                        {
                            IdInmueble = Convert.ToInt32(reader["IdInmueble"]),
                            Direccion = reader["Direccion"].ToString(),
                            Uso = reader["Uso"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            CantidadHabitaciones = Convert.ToInt32(reader["CantidadHabitaciones"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Estado = reader["Estado"].ToString(),
                            IdPropietario = p
                        };
                        res.Add(inm);
                    }
                    connection.Close();
                }
            }
            return res;            
        }
    }
}
