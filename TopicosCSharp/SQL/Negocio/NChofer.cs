using Choferes.Datos;
using Choferes.Entidades;
using System;
using System.Data;

namespace Choferes.Negocio
{
    public class NChofer
    {
        public static DataTable ObtenerChoferes()
        {
            return DChofer.ObtenerChoferes();
        }

        public static DataTable ObtenerNumeroEmpleadoChoferes()
        {
            return DChofer.ObtenerNumeroEmpleadoChoferes();
        }

        public static string Agregar(Chofer chofer)
        {
            string yaExiste = DChofer.BuscarNombreChofer(chofer.Nombres, chofer.Apellidos);

            if (yaExiste == "0")
            {
                return DChofer.AgregarChofer(chofer);
            }

            return "YA EXISTE";
        }

        public static Chofer ObtenerChofer(int numeroEmpleado)
        {
            DataTable tabla = DChofer.ObtenerChofer(numeroEmpleado);

            Chofer chofer = null;

            foreach (DataRow row in tabla.Rows)
            { 
                chofer = new Chofer(
                        row.Field<string>("NOMBRES"),          
                        row.Field<string>("APELLIDOS"),          
                        row.Field<string>("NUM LICENCIA"),          
                        row.Field<DateTime>("FECHA VEN LICENCIA")          
                    );
            }

            return chofer;
        }

        public static DataTable ObtenerChoferesDisponible()
        {
            return DChofer.ObtenerChoferesDisponible();
        }
    }
}
