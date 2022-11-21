using Choferes.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Choferes.Datos
{
    public class DVisita
    {
        public static DataTable ObtenerVistas()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Visita_Listar", conn);
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

        public static DataTable ObtenerClaveVisitas()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Visita_Clave_Listar", conn);
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

        public static string ChecarDisponibilidadChofer(int clave, DateTime fecha)
        {
            SqlConnection conn = null;
            string rpta = "";

            try
            {
                conn = Conexion.CrearConexion();

                SqlCommand comando = new SqlCommand("Visita_Chofer_Disponible", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Chofer", SqlDbType.Int).Value = clave;
                comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = fecha;

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

        public static string AgregarVisita(Visita visita)
        {
            string rpta = "";
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();

                SqlCommand comando = new SqlCommand("Visita_Agregar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Chofer", SqlDbType.Int).Value = visita.Chofer;
                comando.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = visita.FechaInicio;
                comando.Parameters.Add("@FechaFin", SqlDbType.Date).Value = visita.FechaFin;
                comando.Parameters.Add("@NumeroPersonas", SqlDbType.TinyInt).Value = visita.NumeroPersonas;
                comando.Parameters.Add("@TipoEvento", SqlDbType.Char).Value = visita.TipoEvento;
                comando.Parameters.Add("@DescripcionEvento", SqlDbType.NVarChar).Value = visita.DescripcionEvento;
                comando.Parameters.Add("@CiudadDestino", SqlDbType.NVarChar).Value = visita.CiudadDestino;

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

        public static DataTable ObtenerVisita(int clave)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Visita_Obtener", conn);
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
    }
}
