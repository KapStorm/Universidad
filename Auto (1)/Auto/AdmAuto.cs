using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class AdmAuto
    {
        private Dictionary<string, Auto> dicAuto = new Dictionary<string, Auto>(); //Declaración Dictionary

        //METODO AGREGAR AUTO A DICTIONARY
        public void AgregarAuto(string numSerie, string nombre, string marca, byte npasajeros,bool trans, string detalles, string propietario)
        {
            dicAuto.Add(numSerie, new Auto(nombre, marca, npasajeros, trans, detalles, propietario));
        }
        public bool ExisteNumSerie(string numSerie)
        {
            return dicAuto.ContainsKey(numSerie); //CONSTAINSKEY VERIFICA LLAVES REPETIDAS.
        }

        public List<string> RegresaNumSerie() //Metodo para retornar una lista con los numeros de serie
        {
            List<string> lista = new List<string>();
            foreach (string llave in dicAuto.Keys) //Devuelve la key del dictionary
            {
                lista.Add(llave); //Agregamos a la lista nuestra llave 
            }
            return lista;
        }
        public Auto GetAuto(string numS) //Se retorna el numero de serie del dictionary
        {
            return dicAuto[numS]; 
        }
        public bool CampoVacio(string campo) //Metodo para validar que los campos ingresados contengan caracteres
        {
            bool retorno = false;
            if (String.IsNullOrEmpty(campo)) //Si es nulo o tiene espacios blancos
            {
                retorno = true;
            }
            return retorno;
        }

        public List<Auto> RegresaAutos() //Metodo para retornar una lista con objetos de tipo auto
        {
            List<Auto> lista = new List<Auto>();
            foreach (Auto llave in this.dicAuto.Values) 
            {
                lista.Add(llave); 
            }
            return lista;
        }
    }
}
