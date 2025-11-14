using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryAgenda
{
    internal class Conexion
    {
        private string cadenaConexion = "Data Source=SANTIAGO\\SQLEXPRESS;Initial Catalog=AgendaDB;Integrated Security=True;";

        public DataTable ObtenerActividades()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT IdActividad, Asunto, Fecha, Observacion FROM Actividades ORDER BY Fecha ASC";

            try
            {
                // Usar SqlConnection
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Usar SqlCommand
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        conexion.Open();
                        // Usar SqlDataAdapter
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar datos de la base de datos: " + ex.Message);
            }
            return dt;
        }
    
        public void AgregarActividad(string asunto, DateTime fecha, string observacion)
        {
            string consulta = "INSERT INTO Actividades (Asunto, Fecha, Observacion) VALUES (@asunto, @fecha, @observacion)";

            try
            {
                // Usar SqlConnection
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Usar SqlCommand
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        // Se usan parámetros con nombre en SqlClient
                        comando.Parameters.AddWithValue("@asunto", asunto);
                        comando.Parameters.AddWithValue("@fecha", fecha);
                        comando.Parameters.AddWithValue("@observacion", observacion);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la actividad: " + ex.Message);
            }
        }

        public void EliminarActividad(int idActividad)
        {
            string consulta = "DELETE FROM Actividades WHERE IdActividad = @id";

            try
            {
                // Usar SqlConnection
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Usar SqlCommand
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idActividad);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la actividad: " + ex.Message);
            }
        }
    }
}
