using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryAgenda
{
    internal class Conexion
    {
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Base de Datos\ActividadesDB.accdb;";

        public DataTable ObtenerActividades()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT IdActividad, Asunto, Fecha, Observacion FROM Actividades ORDER BY Fecha ASC";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        conexion.Open();
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
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
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        // Nota: OleDb usa el orden posicional de los parámetros
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
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
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
