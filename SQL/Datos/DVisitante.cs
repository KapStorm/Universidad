using Choferes.Entidades;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Choferes.Datos
{
    public class DVisitante
    {
        public static DataTable ObtenerVisitantes()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Visitante_Listar", conn);
                comando.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerClaveVisitantes()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Visitante_Listar_Claves", conn);
                comando.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerVisitante(int clave)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Visitante_Obtener", conn);
                comando.Parameters.Add("@Clave", SqlDbType.Int).Value = clave;
                comando.CommandType = CommandType.StoredProcedure;
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

        public static string AgregarVisitante(Visitante visitante)
        {
            string rpta = "";
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();

                SqlCommand comando = new SqlCommand("Visitante_Agregar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = visitante.Nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = visitante.Apellidos;
                comando.Parameters.Add("@Edad", SqlDbType.TinyInt).Value = visitante.Edad;

                rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return rpta;
        }

        public static string BuscarNombreVisitante(string nombres, string apellidos)
        {
            SqlConnection conn = null;
            string rpta = "";

            try
            {
                conn = Conexion.CrearConexion();

                SqlCommand comando = new SqlCommand("Visitante_Existe_Nombre", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = apellidos;

                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@Existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;

                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();

                rpta = parExiste.Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return rpta;
        }
    }
}
