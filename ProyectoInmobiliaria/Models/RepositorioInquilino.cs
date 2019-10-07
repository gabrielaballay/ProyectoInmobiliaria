using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class RepositorioInquilino : RepositorioBase, IRepositorio<Inquilino>
    {
        public RepositorioInquilino(IConfiguration configuration) : base(configuration) { }

        public int Alta(Inquilino i)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"INSERT INTO Inquilinos (Nombre, Apellido, Dni, Direccion, Email, Telefono, LugarTrabajo, NombreGarante, ApellidoGarante, DniGarante, DireccionGarante, EmailGarante, TelefonoGarante, LugarTrabajoGarante )" +
                    $" VALUES ('{i.Nombre}', '{i.Apellido}', {i.Dni}, '{i.Direccion}', '{i.Email}', '{i.Telefono}','{i.LugarTrabajo}' ,'{i.NombreGarante}', '{i.ApellidoGarante}', {i.DniGarante}, '{i.DireccionGarante}', '{i.EmailGarante}', '{i.TelefonoGarante}','{i.LugarTrabajoGarante}')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    command.CommandText = "SELECT SCOPE_IDENTITY()";
                    var id = command.ExecuteScalar();
                    i.IdInquilino = Convert.ToInt32(id);
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
                string sql = $"DELETE FROM Inquilinos WHERE IdInquilino={id}";
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

        public int Modificacion(Inquilino i)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"UPDATE Inquilinos SET Nombre='{i.Nombre}', Apellido='{i.Apellido}', Dni={i.Dni}, Direccion='{i.Direccion}', Email='{i.Email}'," +
                    $" Telefono={i.Telefono}, LugarTrabajo='{i.LugarTrabajo}', NombreGarante='{i.NombreGarante}', ApellidoGarante='{i.ApellidoGarante}'," +
                    $" DniGarante={i.DniGarante}, DireccionGarante='{i.DireccionGarante}', EmailGarante='{i.EmailGarante}', TelefonoGarante={i.TelefonoGarante}, LugarTrabajoGarante='{i.LugarTrabajoGarante}' WHERE IdInquilino={i.IdInquilino}";

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

        public Inquilino ObtenerPorEmail(string email)
        {
            Inquilino inquilino = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdInquilino,Nombre,Apellido,Dni,Direccion,Email,Telefono,LugarTrabajo, NombreGarante,ApellidoGarante" +
                    $",DniGarante,DireccionGarante,EmailGarante,TelefonoGarante,LugarTrabajoGarante FROM Inquilinos WHERE Email=@email";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        inquilino = new Inquilino
                        {
                            IdInquilino = reader.GetInt32(0),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            LugarTrabajo = reader["LugarTrabajo"].ToString(),
                            NombreGarante = reader["NombreGarante"].ToString(),
                            ApellidoGarante = reader["ApellidoGarante"].ToString(),
                            DniGarante = reader["DniGarante"].ToString(),
                            DireccionGarante = reader["DireccionGarante"].ToString(),
                            EmailGarante = reader["EmailGarante"].ToString(),
                            TelefonoGarante = reader["TelefonoGarante"].ToString(),
                            LugarTrabajoGarante = reader["LugarTrabajoGarante"].ToString(),

                        };
                    }
                    connection.Close();
                }
            }
            return inquilino;
        }

        public Inquilino ObtenerPorId(int id)
        {
            Inquilino inquilino = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdInquilino,Nombre,Apellido,Dni,Direccion,Email,Telefono,LugarTrabajo, NombreGarante,ApellidoGarante" +
                    $",DniGarante,DireccionGarante,EmailGarante,TelefonoGarante,LugarTrabajoGarante FROM Inquilinos WHERE IdInquilino=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        inquilino = new Inquilino
                        {
                            IdInquilino = reader.GetInt32(0),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            LugarTrabajo = reader["LugarTrabajo"].ToString(),
                            NombreGarante = reader["NombreGarante"].ToString(),
                            ApellidoGarante = reader["ApellidoGarante"].ToString(),
                            DniGarante = reader["DniGarante"].ToString(),
                            DireccionGarante = reader["DireccionGarante"].ToString(),
                            EmailGarante = reader["EmailGarante"].ToString(),
                            TelefonoGarante = reader["TelefonoGarante"].ToString(),
                            LugarTrabajoGarante = reader["LugarTrabajoGarante"].ToString(),

                        };
                    }
                    connection.Close();
                }
                return inquilino;
            }
        }

        public IList<Inquilino> ObtenerTodos()
        {
            IList<Inquilino> res = new List<Inquilino>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdInquilino,Nombre,Apellido,Dni,Direccion,Email,Telefono,LugarTrabajo, NombreGarante,ApellidoGarante" +
                    $",DniGarante,DireccionGarante,EmailGarante,TelefonoGarante,LugarTrabajoGarante FROM Inquilinos";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Inquilino i=new Inquilino
                        {
                            IdInquilino = reader.GetInt32(0),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            LugarTrabajo = reader["LugarTrabajo"].ToString(),
                            NombreGarante = reader["NombreGarante"].ToString(),
                            ApellidoGarante = reader["ApellidoGarante"].ToString(),
                            DniGarante = reader["DniGarante"].ToString(),
                            DireccionGarante = reader["DireccionGarante"].ToString(),
                            EmailGarante = reader["EmailGarante"].ToString(),
                            TelefonoGarante = reader["TelefonoGarante"].ToString(),
                            LugarTrabajoGarante = reader["LugarTrabajoGarante"].ToString(),
                        };
                        res.Add(i);
                    }
                    connection.Close();
                }
            }
            return res;
        }
    }
}
