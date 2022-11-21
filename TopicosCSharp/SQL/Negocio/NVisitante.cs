using Choferes.Datos;
using Choferes.Entidades;
using System.Data;

namespace Choferes.Negocio
{
    public class NVisitante
    {
        public static DataTable ObtenerVisitantes()
        {
            return DVisitante.ObtenerVisitantes();
        }

        public static DataTable ObtenerClaveVisitantes()
        {
            return DVisitante.ObtenerClaveVisitantes();
        }

        public static Visitante ObtenerVisitante(int clave)
        {
            DataTable tabla = DVisitante.ObtenerVisitante(clave);
            Visitante visitante = null;

            foreach (DataRow row in tabla.Rows)
            {
                visitante = new Visitante(
                        row.Field<string>("NOMBRES"),
                        row.Field<string>("APELLIDOS"),
                        row.Field<byte>("EDAD")
                    );
            }

            return visitante;
        }

        public static string AgregarVisitante(Visitante visitante)
        {
            string yaExiste = DVisitante.BuscarNombreVisitante(visitante.Nombres, visitante.Apellidos);

            if (yaExiste == "0")
            {
                return DVisitante.AgregarVisitante(visitante);
            }

            return "YA EXISTE";
        }
    }
}
