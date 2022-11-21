using System.Data.SqlClient;
using System.Data;
using System;
using System.Security.Claims;

namespace Choferes.Datos
{
    public class DVisitaVisitante
    {
        public static DataTable ObtenerDatos(int clave)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("VisitaVisitante_Listar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Clave", SqlDbType.Int).Value = clave;
                lector = comando.ExecuteReader();
                tabla.Load(lector);

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public static string AgregarVisitanteAVisita(int claveVisita, int claveVisitante)
        {
            string rpta = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("VisitaVisitante_Agregar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ClaveVisita", SqlDbType.Int).Value = claveVisita;
                comando.Parameters.Add("@ClaveVisitante", SqlDbType.Int).Value = claveVisitante;
                rpta = comando.ExecuteNonQuery() == 1
                    ? "Ok"
                    : "No se pudo ingresar el registro";

                return rpta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public static string ChecarSiYaEsta(int claveVisita, int claveVisitante)
        {
            string rpta = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("VisitaVisitante_Existe", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ClaveVisita", SqlDbType.Int).Value = claveVisita;
                comando.Parameters.Add("@ClaveVisitante", SqlDbType.Int).Value = claveVisitante;

                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@Existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;

                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();

                rpta = parExiste.Value.ToString();

                return rpta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
