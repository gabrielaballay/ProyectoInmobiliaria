using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class RepositorioPropietario : RepositorioBase, IRepositorio<Propietario>
    {
        public RepositorioPropietario(IConfiguration configuration) : base(configuration) { }
        public int Alta(Propietario p)
        {
            int res = -1;
            using (SqlConnection connection= new SqlConnection(connectionStrings))
            {
                string sql = $"INSERT INTO Propietarios (Nombre, Apellido, Dni, Password, Direccion, Email, Telefono)" +
                    $"VALUES ('{p.Nombre}', '{p.Apellido}', {p.Dni}, '{p.Password}', '{p.Direccion}', '{p.Email}', {p.Telefono})";
             
                using(SqlCommand command=new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    command.CommandText = "SELECT SCOPE_IDENTITY()";
                    var id = command.ExecuteScalar();
                    p.IdPropietario = Convert.ToInt32(id);
                    connection.Close();
                }
            }
            return res;
        }

        public int Baja(int id)
        {
            int res = -1;
            using(SqlConnection connection=new SqlConnection(connectionStrings))
            {
                string sql = $"DELETE FROM Propietarios WHERE IdPropietario={id}";
                using(SqlCommand command=new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }

        public int Modificacion(Propietario p)
        {
            int res = -1;

            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"UPDATE Propietarios SET Nombre='{p.Nombre}', Apellido='{p.Apellido}', Dni={p.Dni}," +
                    $" Direccion='{p.Direccion}', Email='{p.Email}', Telefono={p.Telefono} WHERE IdPropietario = {p.IdPropietario}";

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

        public Propietario ObtenerPorId(int id)
        {
            Propietario p = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdPropietario,Nombre,Apellido,Dni,Password,Direccion,Email,Telefono FROM Propietarios" +
                    $" WHERE IdPropietario=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        p = new Propietario
                        {
                            IdPropietario = reader.GetInt32(0),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Password = reader["Password"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };
                    }
                    connection.Close();
                }
            }
            return p;
        }

        public IList<Propietario> ObtenerTodos()
        {
            IList<Propietario> res = new List<Propietario>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdPropietario,Nombre,Apellido,Dni,Password,Direccion,Email,Telefono FROM Propietarios";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Propietario p = new Propietario
                        {
                            IdPropietario = reader.GetInt32(0),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Password = reader["Password"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };
                        res.Add(p);
                    }
                    connection.Close();
                }
            }
            return res;
        }

        public Propietario ObtenerPorEmail(string emai)
        {
            Propietario p = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdPropietario,Nombre,Apellido,Dni,Password,Direccion,Email,Telefono FROM Propietarios" +
                    $" WHERE Email=@emai";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@emai", SqlDbType.VarChar).Value = emai;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        p = new Propietario
                        {
                            IdPropietario = reader.GetInt32(0),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Password = reader["Password"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };
                    }
                    connection.Close();
                }
            }
            return p;
        }
    }
}
