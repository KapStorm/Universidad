using Choferes.Datos;
using System.Data;

namespace Choferes.Negocio
{
    public class NVisitaVisitante
    {
        public static DataTable ObtenerDatos(int clave)
        {
            return DVisitaVisitante.ObtenerDatos(clave);
        }

        public static string AgregarVisitanteAVisita(int claveVisita, int claveVisitante)
        {
            string rpta = DVisitaVisitante.ChecarSiYaEsta(claveVisita, claveVisitante);
            if (rpta == "0")
            {
                return DVisitaVisitante.AgregarVisitanteAVisita(claveVisita, claveVisitante);
            }

            return "YA EXISTE";
        }
    }
}
