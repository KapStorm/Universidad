using Choferes.Datos;
using Choferes.Entidades;
using System;
using System.Data;

namespace Choferes.Negocio
{
    public class NVisita
    {
        public static DataTable ObtenerVistas()
        {
            return DVisita.ObtenerVistas();
        }

        public static string Agregar(Visita visita)
        {
            string yaExiste = DVisita.ChecarDisponibilidadChofer(visita.Chofer, visita.FechaInicio);

            if (yaExiste == "0")
            {
                return DVisita.AgregarVisita(visita);
            }

            return "CHOFER NO DISPONIBLE";
        }

        public static DataTable ObtenerClaveVisitas()
        {
            return DVisita.ObtenerClaveVisitas();
        }

        public static Visita ObtenerVisita(int clave)
        {
            DataTable tabla = DVisita.ObtenerVisita(clave);

            Visita visita = null;

            foreach (DataRow row in tabla.Rows)
            {
                visita = new Visita(
                        row.Field<int>("CHOFER"),
                        row.Field<DateTime>("FECHA INICIO"),
                        row.Field<DateTime>("FECHA FIN"),
                        row.Field<byte>("NUMERO PERSONAS"),
                        row.Field<string>("TIPO EVENTO")[0],
                        row.Field<string>("DESCRIPCION EVENTO"),
                        row.Field<string>("CIUDAD DESTINO")
                    );
            }

            return visita;
        }
    }
}
