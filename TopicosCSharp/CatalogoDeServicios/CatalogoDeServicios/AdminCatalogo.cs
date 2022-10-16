using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*
 * Hecho por: Arellanes Beltran Sebastian
 */
namespace CatalogoDeServicios
{
    // Clase para manejar lo relativo a los
    // objetos del arreglo o catalogo de servicios
    // En esta clase NO SE PIDEN DATOS
    // TAMPOCO SE MUESTRAN
    public class AdministraCatalogo
    {
        // Atributos para el arreglo y el total de servicios
        private CatalogoServ[] arrCatalogo;
        private int totalServ;

        // Constructor para incializar los atributos
        public AdministraCatalogo()
        {
            arrCatalogo = new CatalogoServ[30];
            totalServ = 0;
        }

        // Metodo para agregar servicio
        public bool AgregaServicio(byte claveServicio, string nombreServicio, double costo)
        {
            bool validar = true;

            // Checamos si el arreglo esta lleno
            if (ChecarArregloLleno())
                validar = false;
            else
            {
                arrCatalogo[totalServ] = new CatalogoServ(claveServicio, nombreServicio, costo);
                totalServ++;
            }

            // Retornamos si es valido
            return validar;
        }

        // Metodo para checar si el arreglo esta lleno
        public bool ChecarArregloLleno()
        {
            return totalServ >= arrCatalogo.Length;
        }
        
        // Metodo para listar los servicios
        public List<CatalogoServ> ListadoServicios()
        {
            // Inicializamos la lista
            List<CatalogoServ> listaRetorno = new List<CatalogoServ>();

            // Agregamos los servicios disponibles
            for (int i = 0; i < totalServ; i++)
                listaRetorno.Add(arrCatalogo[i]);

            // Retornamos la lista
            return listaRetorno;
        }

        // Metodo para consultar un servicio con su clave
        public CatalogoServ ConsultarServicio(byte claveServicio)
        {
            // Variable
            CatalogoServ catalogo = null;

            // Buscamos el servicio
            for (int i = 0; i < totalServ; i++)
                if (arrCatalogo[i].ClaveServicio == claveServicio)
                {
                    catalogo = arrCatalogo[i];
                    break;
                }

            // Retornamos el catalogo 
            return catalogo;
        }

        // Modificamos el costo
        public bool ModificarCosto(byte claveServicio, double costo)
        {
            bool validar = false;
            // Buscamos la clave existe
            int clave = BuscarClavePos(claveServicio);

            // Si existe
            if (clave >= 0)
            {
                arrCatalogo[clave].Costo = costo;
                validar = true;
            }

            // Retornamos el bool
            return validar;
        }

        // Metodo que retorna los servicios que tengan el nombre del parametro
        public List<CatalogoServ> BuscarPorNombre(string nombreServicio)
        {
            // Incializamos
            List<CatalogoServ> lista = new List<CatalogoServ>();

            // Buscamos los catalogos por nombre y agregamos
            for (int i = 0; i < totalServ; i++)
                if (arrCatalogo[i].NombreServicio == nombreServicio)
                    lista.Add(arrCatalogo[i]);

            // Retornamos la lista
            return lista;
        }

        // Buscamos la clave y retornamos la posicion
        public int BuscarClavePos(byte clave)
        {
            int pos = -1;

            // Buscamos la posicion
            for (int i = 0; i < totalServ; i++)
                if (arrCatalogo[i].ClaveServicio == clave)
                {
                    pos = i;
                    break;
                }

            // Retornamos la posicion
            return pos;
        }

        // Metodo que retorna una lista con los servicios por precio
        public List<CatalogoServ> ImprimirPorPrecioAscendente()
        {
            // Obtenemos los servicios con el metodo
            List<CatalogoServ> lista = ListadoServicios();
            
            // Compara y ordenamos por Costo
            lista.Sort(delegate(CatalogoServ catalogo1, CatalogoServ catalogo2)
            {
                return catalogo1.Costo.CompareTo(catalogo2.Costo);
            });

            // Retorna la lista
            return lista;
        }

        // Imprime los servicios alfabeticament
        public List<CatalogoServ> ImprimeAlfabeticamente()
        {
            // Obtenemos los servicios con el metodo
            List<CatalogoServ> lista = ListadoServicios();

            // Comparamos y ordenamos por Nombre
            lista.Sort(delegate(CatalogoServ catalogo1, CatalogoServ catalogo2)
            {
                return catalogo1.NombreServicio.CompareTo(catalogo2.NombreServicio);
            });
            
            // Retornamos la lista
            return lista;
        }
    }
}