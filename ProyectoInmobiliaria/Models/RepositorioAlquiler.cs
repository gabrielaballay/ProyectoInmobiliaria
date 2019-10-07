using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class RepositorioAlquiler: RepositorioBase, IRepositorio<Alquiler>
    {
        public RepositorioAlquiler(IConfiguration configuration) : base(configuration) { }

        public int Alta(Alquiler a)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"INSERT INTO Alquiler (FechaInicio, FechaFin, Monto, IdInmueble, IdInquilino)" +
                    $"VALUES ('{a.FechaInicio}','{a.FechaFin}',{a.Monto},{a.IdInmueble},{a.IdInquilino})";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    command.CommandText = "SELECT SCOPE_IDENTITY()";
                    var id = command.ExecuteScalar();
                    a.IdAlquiler = Convert.ToInt32(id);
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
                string sql = $"DELETE FROM Alquiler WHERE IdAlquiler = {id}";
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

        public int Modificacion(Alquiler a)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                Decimal numero = decimal.Round(a.Monto, 0);
                string sql = $"UPDATE Alquiler SET FechaInicio='{a.FechaInicio}', FechaFin='{a.FechaFin}', Monto={numero}, IdInmueble={a.IdInmueble}, " +
                    $"IdInquilino={a.IdInquilino} WHERE IdAlquiler = {a.IdAlquiler}";
                   

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

        public Alquiler ObtenerPorId(int id)
        {
            Alquiler alquiler = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdAlquiler, FechaInicio,FechaFin,Monto, al.IdInmueble, al.IdInquilino, i.Apellido, i.Nombre, inm.Direccion " +
                    $"FROM Alquiler AS al JOIN Inquilinos AS i ON (al.IdInquilino = i.IdInquilino) JOIN Inmuebles AS inm ON (al.IdInmueble=inm.IdInmueble) " +
                    $"WHERE IdAlquiler=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        alquiler=new Alquiler
                        {
                            IdInmueble = reader.GetInt32(0),
                            FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                            FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                            Monto = Convert.ToDecimal(reader["Monto"]),
                            IdAlquiler = Convert.ToInt32(reader["IdAlquiler"]),
                            IdInquilino = Convert.ToInt32(reader["IdInquilino"]),
                            casa = new Inmueble
                            {
                                IdInmueble = reader.GetInt32(4),
                                Direccion = reader.GetString(8),
                            },
                            inquilino = new Inquilino
                            {
                                IdInquilino = reader.GetInt32(5),
                                Nombre = reader.GetString(6),
                                Apellido = reader.GetString(7)
                            }
                        };
                    }
                    connection.Close();
                }
            }
            return alquiler;
        }

        public IList<Alquiler> ObtenerTodos()
        {
            IList<Alquiler> res = new List<Alquiler>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdAlquiler, FechaInicio,FechaFin,Monto, al.IdInmueble, al.IdInquilino, i.Apellido, i.Nombre, inm.Direccion " +
                    $"FROM Alquiler AS al JOIN Inquilinos AS i ON (al.IdInquilino = i.IdInquilino) JOIN Inmuebles AS inm ON (al.IdInmueble=inm.IdInmueble)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Alquiler alq = new Alquiler
                        {
                            IdInmueble = reader.GetInt32(0),
                            FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                            FechaFin=Convert.ToDateTime(reader["FechaFin"]),
                            Monto=Convert.ToDecimal(reader["Monto"]),
                            IdAlquiler=Convert.ToInt32(reader["IdAlquiler"]),
                            IdInquilino=Convert.ToInt32(reader["IdInquilino"]),
                            casa = new Inmueble
                            {
                                IdInmueble = reader.GetInt32(4),
                                Direccion = reader.GetString(8),
                            },
                            inquilino=new Inquilino
                            {
                                IdInquilino=reader.GetInt32(5),
                                Nombre=reader.GetString(6),
                                Apellido=reader.GetString(7)
                            }
                        };
                        res.Add(alq);
                    }
                    connection.Close();
                }
            }
            return res;
        }
    }
}
