using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class AdministraCatalogoServicio
    {
        private Dictionary<string, CatalogoServicio> dicCat = new Dictionary<string, CatalogoServicio>();
        
        public void AgregarServicio(string clave,string nombre,double costo)
        {
            dicCat.Add(clave, new CatalogoServicio(nombre, costo));
        }
        public bool BuscaClave(string clave)//Este metodo busca el numero de serie para revisar que no se repita
        {
            return dicCat.ContainsKey(clave);
        }
        public List<string> RegresaClave() //Este metodo devuelve la lista de objetos que esten ya registrados
        {
            List<string> listado = new List<string>();
            foreach (string e in dicCat.Keys)//Se recorre el dictionary
            {
                listado.Add(e);//Si hay objeto se agrega a la lista
            }
            return listado;
        }
        public CatalogoServicio RegresaCatalogo(string clave)
        {
            return dicCat[clave];
        }
        public List<CatalogoServicio> RegresaCatalogoServicio()
        {
            List<CatalogoServicio> listado = new List<CatalogoServicio>();
            foreach (CatalogoServicio e in dicCat.Values)
            {
                listado.Add(e);
            }
            return listado;
        }
    }
}
