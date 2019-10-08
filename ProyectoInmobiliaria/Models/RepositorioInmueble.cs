using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class RepositorioInmueble : RepositorioBase, IRepositorioInmueble
    {
        public RepositorioInmueble(IConfiguration configuration) : base(configuration) { }
        public int Alta(Inmueble inmueble)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"INSERT INTO Inmuebles (Direccion, Uso, Tipo, CantidadHabitaciones,Precio,Estado, IdPropietario)" +
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
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"DELETE FROM Inmuebles WHERE IdInmueble = {id}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }

        public IList<Inmueble> BuscarPorPropietario(int idPropietario)
        {
            List<Inmueble> res = new List<Inmueble>();
            Inmueble inmueble = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT i.Direccion, i.Uso, i.Tipo, i.CantidadHabitaciones,i.Precio,i.Estado, i.IdPropietario, p.Nombre, p.Apellido" +
                    $" FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario" +
                    $" WHERE IdPropietario=@idPropietario";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@idPropietario", SqlDbType.Int).Value = idPropietario;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        inmueble = new Inmueble
                        {
                            IdInmueble = reader.GetInt32(0),
                            Direccion = reader["Direccion"].ToString(),
                            Uso = reader["Uso"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            CantidadHabitaciones = Convert.ToInt32(reader["CantidadHabitaciones"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Estado = reader["Estado"].ToString(),
                            IdPropietario = reader.GetInt32(6),
                            Duenio = new Propietario
                            {
                                IdPropietario = reader.GetInt32(6),
                                Nombre = reader.GetString(7),
                                Apellido = reader.GetString(8),
                            }
                        };
                        res.Add(inmueble);
                    }
                    connection.Close();
                }
            }
            return res;
        }

        public int Modificacion(Inmueble inmueble)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"UPDATE Inmuebles SET Direccion=@direccion, Uso=@uso, Tipo=@tipo, CantidadHabitaciones=@cantidad," +
                    $" Precio=@precio, Estado=@estado, IdPropietario=@propietarioId " +
                    $"WHERE IdInmueble = {inmueble.IdInmueble}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@direccion", SqlDbType.VarChar).Value = inmueble.Direccion;
                    command.Parameters.Add("@uso", SqlDbType.VarChar).Value = inmueble.Uso;
                    command.Parameters.Add("@tipo", SqlDbType.VarChar).Value = inmueble.Tipo;
                    command.Parameters.Add("@cantidad", SqlDbType.Int).Value = inmueble.CantidadHabitaciones;
                    command.Parameters.Add("@precio", SqlDbType.Decimal).Value = inmueble.Precio;
                    command.Parameters.Add("@estado", SqlDbType.VarChar).Value = inmueble.Estado;
                    command.Parameters.Add("@propietarioId", SqlDbType.Int).Value = inmueble.IdPropietario;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }     

        public Inmueble ObtenerPorId(int id)
        {
            Inmueble inmueble = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT i.IdInmueble, i.Direccion, i.Uso, i.Tipo, i.CantidadHabitaciones,i.Precio,i.Estado, i.IdPropietario, p.Nombre, p.Apellido" +
                    $" FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario" +
                    $" WHERE IdInmueble=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        inmueble = new Inmueble
                        {
                            IdInmueble = Convert.ToInt32(reader["IdInmueble"]),
                            Direccion = reader["Direccion"].ToString(),
                            Uso = reader["Uso"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            CantidadHabitaciones = Convert.ToInt32(reader["CantidadHabitaciones"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Estado = reader["Estado"].ToString(),
                            IdPropietario = reader.GetInt32(7),
                            Duenio = new Propietario
                            {
                                IdPropietario = reader.GetInt32(7),
                                Nombre = reader.GetString(8),
                                Apellido = reader.GetString(9)
                            }
                        };
                    }
                    connection.Close();
                }
            }
            return inmueble;
        }

        public IList<Inmueble> ObtenerTodos()
        {
            IList<Inmueble> res = new List<Inmueble>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT i.IdInmueble, i.Direccion, i.Uso, i.Tipo, i.CantidadHabitaciones,i.Precio,i.Estado, i.IdPropietario, p.Nombre, p.Apellido FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {                        
                        Inmueble inm = new Inmueble
                        {
                            IdInmueble = reader.GetInt32(0),
                            Direccion = reader["Direccion"].ToString(),
                            Uso = reader["Uso"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            CantidadHabitaciones = Convert.ToInt32(reader["CantidadHabitaciones"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Estado = reader["Estado"].ToString(),
                            IdPropietario = reader.GetInt32(7),
                            Duenio = new Propietario
                            {                                 
                                IdPropietario = reader.GetInt32(7),
                                Nombre = reader.GetString(8),
                                Apellido = reader.GetString(9)
                            }
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
