using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Carro
    {
        //Atributos de clase
        private string Nombre;
        private string Marca;
        private int NumPasajeros;
        private string Transmision;
        private string Detalle;

        //Constructor
        public Carro(string Nombre, string Marca, int NumPasajeros,string Transmision,string Detalle)
        {
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.NumPasajeros = NumPasajeros;
            this.Transmision = Transmision;
            this.Detalle = Detalle;
        }
        //Propiedades get y set
        public string pNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string pMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public int pNumPasajeros
        {
            get { return NumPasajeros; }
            set { NumPasajeros = value; }
        }
        public string pTransmision
        {
            get { return Transmision; }
            set { Transmision = value; }
        }
        public string pDetalle
        {
            get { return Detalle; }
            set { Detalle = value; }
        }
    }
}
