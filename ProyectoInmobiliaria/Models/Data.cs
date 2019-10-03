using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Data
    {
        public List<Propietario> ObtenerPropietarios()
        {
            List<Propietario> res = new List<Propietario>();
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\LAURA\\DOCUMENTS\\GITHUB\\PROYECTOINMOBILIARIA\\PROYECTOINMOBILIARIA\\DATA\\INMODB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string sql = "SELECT * FROM Propietarios";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            var reader = comm.ExecuteReader();
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
            conn.Close();
            return res;
        }
    }
}
