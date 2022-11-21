using Choferes.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Choferes.Datos
{
    public class DChofer
    {
        public static DataTable ObtenerChoferes()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Chofer_Listar", conn);
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

        public static DataTable ObtenerNumeroEmpleadoChoferes()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Chofer_NumEmpleado_Listar", conn);
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

        public static string BuscarNombreChofer(string nombres, string apellidos)
        {
            SqlConnection conn = null;
            string rpta = "";

            try
            {
                conn = Conexion.CrearConexion();

                SqlCommand comando = new SqlCommand("Chofer_ExisteNombre", conn);
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

        public static string AgregarChofer(Chofer chofer)
        {
            string respuesta = "";
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();

                SqlCommand comando = new SqlCommand("Chofer_Agregar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = chofer.Nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = chofer.Apellidos;
                comando.Parameters.Add("@NumeroLicencia", SqlDbType.VarChar).Value = chofer.NumeroLicencia;
                comando.Parameters.Add("@FechaVencimientoLicencia", SqlDbType.Date).Value = chofer.FechaVencimientoLicencia;

                respuesta = comando.ExecuteNonQuery() == 1 
                    ? "Ok" 
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

            return respuesta;
        }

        public static DataTable ObtenerChofer(int numeroEmpleado)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Chofer_Obtener", conn);
                comando.Parameters.Add("@NumEmpleado", SqlDbType.Int).Value = numeroEmpleado;
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

        public static DataTable ObtenerChoferesDisponible()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Chofer_Disponibles", conn);
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
    }
}
