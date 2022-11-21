using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Administrador
    {
        private Dictionary<string, Carro> dicCarro = new Dictionary<string, Carro>();//Se crea dictionary para la organizacion
        public void AgregaCarro(string NumSerie,string Nombre,string Marca,int NumPasajeros,string Transmision,string Detalle)//Este metodo sirve para agregar un carro
        {
            dicCarro.Add(NumSerie, new Carro(Nombre, Marca, NumPasajeros,Transmision,Detalle));//Creamos el objeto que agregaremos al dictionary
        }
        public bool BuscaNumSerie(string NumSerie)//Este metodo busca el numero de serie para revisar que no se repita
        {
            return dicCarro.ContainsKey(NumSerie);
        }
        public List<string> RegresaNumSerie() //Este metodo devuelve la lista de objetos que esten ya registrados
        {
            List<string> listado = new List<string>();
            foreach (string e in dicCarro.Keys)//Se recorre el dictionary
            {
                listado.Add(e);//Si hay objeto se agrega a la lista
            }
            return listado;
        }

        public Carro RegresaAuto(string numS)//Este metodo devolvera el objeto que coincida con el numSerie
        {
            return dicCarro[numS];//Devuelve el objeto encontrado
        }
        public List<Carro> RegresaCarros() {
            List<Carro> listado = new List<Carro>();
            foreach (Carro e in dicCarro.Values)
            {
                listado.Add(e);
            }
            return listado;
        }
        
    }
}
