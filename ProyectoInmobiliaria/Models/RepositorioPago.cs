using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class RepositorioPago : RepositorioBase, IRepositorio<Pago>
    {
        public RepositorioPago(IConfiguration configuration) : base(configuration) { }

        public int Alta(Pago p)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"INSERT INTO Pagos (Estado, FechaPago, Importe, IdAlquiler)" +
                    $"VALUES ('{p.Estado}','{p.FechaPago}',{p.Importe},{p.IdAlquiler})";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    command.CommandText = "SELECT SCOPE_IDENTITY()";
                    var id = command.ExecuteScalar();
                    p.IdPagos = Convert.ToInt32(id);
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
                string sql = $"DELETE FROM Pagos WHERE IdPago = {id}";
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

        public int Modificacion(Pago p)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                Decimal numero = decimal.Round(p.Importe, 0);
                string sql = $"UPDATE Alquiler SET Estado='{p.Estado}', FechaPago='{p.FechaPago}'" +
                    $"Importe={numero}, IdAlquiler={p.IdAlquiler} WHERE IdPago = {p.IdPagos}";
                
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

        public Pago ObtenerPorId(int id)
        {
            Pago p = null;
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdPago, p.Estado, p.FechaPago, p.Importe, p.IdAlquiler " +
                    $"FROM Pagos p INNER JOIN Alquiler a ON p.IdAlquiler = a.IdAlquiler WHERE IdPago={id}";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();                    
                    while (reader.Read())
                    {
                        p = new Pago
                        {
                            IdPagos = reader.GetInt32(0),
                            Estado = reader["Estado"].ToString(),
                            FechaPago = Convert.ToDateTime(reader["FechaPago"]),
                            Importe = Convert.ToDecimal(reader["Importe"]),
                            IdAlquiler= Convert.ToInt32(reader["IdAlquiler"]),
                            Alquilado = new Alquiler
                            {
                                IdAlquiler = Convert.ToInt32(reader["IdAlquiler"]),
                            }
                        };
                    }
                    connection.Close();
                }
            }
            return p;
        }

        public IList<Pago> ObtenerTodos()
        {
            IList<Pago> res = new List<Pago>();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                string sql = $"SELECT IdPago, p.Estado, p.FechaPago, p.Importe, p.IdAlquiler,a.IdInmueble " +
                    $"FROM Pagos AS p JOIN Alquiler AS a ON (p.IdAlquiler = a.IdAlquiler)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Pago p = new Pago
                        {
                            IdPagos = reader.GetInt32(0),
                            Estado = reader["Estado"].ToString(),
                            FechaPago=Convert.ToDateTime(reader["FechaPago"]),
                            Importe=Convert.ToDecimal(reader["Importe"]),
                            IdAlquiler= Convert.ToInt32(reader["IdAlquiler"]),
                            Alquilado = new Alquiler
                            {
                                IdAlquiler=Convert.ToInt32(reader["IdAlquiler"]),
                            }                            
                        };
                        res.Add(p);
                    }
                    connection.Close();
                }
            }
            return res;
        }
    }
}
