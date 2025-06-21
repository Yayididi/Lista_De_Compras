using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lista_Compras
{
    public class CompraService
    {
        private string connectionString = "Server=DESKTOP-DJB7I3F\\MSSQLSERVER01;Database=ListaDeCompras;Trusted_Connection=True;";

        public void AgregarCompra(Articulo a)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"insert into Compras (Articulo, CantidadEstimada, PrecioEstimado, Encontrado, PrecioReal)
                             values (@articulo, @cantidad, @precio, @encontrado, @precioReal)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@articulo", a.Nombre);
                cmd.Parameters.AddWithValue("@cantidad", a.CantidadEstimada);
                cmd.Parameters.AddWithValue("@precio", a.PrecioEstimado);
                cmd.Parameters.AddWithValue("@encontrado", a.Encontrado);
                cmd.Parameters.AddWithValue("@precioReal", a.PrecioReal);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Articulo> ObtenerCompras()
        {
            var lista = new List<Articulo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select * from Compras";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Articulo
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Articulo"].ToString(),
                        CantidadEstimada = (int)reader["CantidadEstimada"],
                        PrecioEstimado = (decimal)reader["PrecioEstimado"],
                        Encontrado = (bool)reader["Encontrado"],
                        PrecioReal = (decimal)reader["PrecioReal"]
                    });
                }
            }
            return lista;
        }

        public void ActualizarArticulo(Articulo a)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Compras SET 
                            CantidadEstimada = @cantidad, 
                            PrecioReal = @precioReal,
                            Encontrado = @encontrado
                         WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cantidad", a.CantidadEstimada);
                cmd.Parameters.AddWithValue("@precioReal", a.PrecioReal);
                cmd.Parameters.AddWithValue("@encontrado", a.Encontrado);
                cmd.Parameters.AddWithValue("@id", a.Id);

                cmd.ExecuteNonQuery();
            }
        }

    }

}
