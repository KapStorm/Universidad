using LibreriaBD;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace Choferes.Datos
{
    public class Conexion
    {
        public static SqlConnection CrearConexion()
        {
            string strCon = GetConnectionString();
            SqlConnection conn;
            try
            {
                conn = UsoBD.ConectaBD(strCon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }

        private static string GetConnectionString()
        {
            string strConn = "";
            try
            {
                strConn = ConfigurationManager.ConnectionStrings["conStrBD"].ConnectionString;
            }
            catch (Exception)
            {
                throw;
            }
            return strConn;
        }
    }
}
