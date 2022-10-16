using System.Collections;
using System.Collections.Generic;

namespace CatalogoDeServicios
{
    // Clase para manejar lo relativo a los
    // objetos del arreglo o catalogo de servicios
    // En esta clase NO SE PIDEN DATOS
    // TAMPOCO SE MUESTRAN
    public class AdministraCatalogo
    {
        private CatalogoServ[] arrCatalogo;
        private int totalServ;

        public AdministraCatalogo()
        {
            arrCatalogo = new CatalogoServ[30];
            totalServ = 0;
        }

        public bool AgregaServicio(byte claveServicio, string nombreServicio, double costo)
        {
            bool validar = true;

            if (ChecarArregloLleno())
                validar = false;
            else
            {
                arrCatalogo[totalServ] = new CatalogoServ(claveServicio, nombreServicio, costo);
                totalServ++;
            }

            return validar;
        }

        public bool ChecarArregloLleno()
        {
            return totalServ >= arrCatalogo.Length;
        }

        public CatalogoServ ConsultarServicio(byte claveServicio)
        {
            CatalogoServ catalogo = null;

            for (int i = 0; i < totalServ; i++)
                if (arrCatalogo[i].ClaveServicio == claveServicio)
                {
                    catalogo = arrCatalogo[i];
                    break;
                }

            return catalogo;
        }

        public bool ModificarCosto(byte claveServicio, double costo)
        {
            bool validar = false;
            int clave = BuscarClavePos(claveServicio);

            if (clave >= 0)
            {
                arrCatalogo[clave].Costo = costo;
                validar = true;
            }

            return validar;
        }

        public CatalogoServ[] BuscarPorNombre(string nombreServicio)
        {
            CatalogoServ[] resultados = new CatalogoServ[arrCatalogo.Length];
            int index = 0;

            for (int i = 0; i < totalServ; i++)
                if (arrCatalogo[i].NombreServicio == nombreServicio)
                {
                    resultados[index] = arrCatalogo[i];
                    break;
                }

            return resultados;
        }

        public List<CatalogoServ> ListadoServicios()
        {
            List<CatalogoServ> listaRetorno = new List<CatalogoServ>();

            for (int i = 0; i < totalServ; i++)
                listaRetorno.Add(arrCatalogo[i]);

            return listaRetorno;
        }

        public int BuscarClavePos(byte clave)
        {
            int pos = -1;

            for (int i = 0; i < totalServ; i++)
                if (arrCatalogo[i].ClaveServicio == clave)
                {
                    pos = i;
                    break;
                }

            return pos;
        }

        public List<CatalogoServ> ImprimirPorPrecioAscendente()
        {
            List<CatalogoServ> lista = ListadoServicios();
            
            // Compara
            lista.Sort(delegate(CatalogoServ catalogo1, CatalogoServ catalogo2)
            {
                return catalogo1.Costo.CompareTo(catalogo2.Costo);
            });

            return lista;
        }

        public List<CatalogoServ> ImprimeAlfabeticamente()
        {
            List<CatalogoServ> lista = ListadoServicios();

            lista.Sort(delegate(CatalogoServ catalogo1, CatalogoServ catalogo2)
            {
                return catalogo1.NombreServicio.CompareTo(catalogo2.NombreServicio);
            });

            return lista;
        }
    }
}