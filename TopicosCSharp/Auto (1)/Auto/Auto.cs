using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
   public class Auto
    {
        //ATRIBUTOS PRIVADOS
        private string nombre;
        private string marca;
        private byte numPasajeros;
        private bool estandar; //Agregramos el nuevo atributo de tipo bool, puse estandar porque es el valor default
        private string detalles; //Agregamos el checkBox
        private string propietario; //Agregamos nuevo atributo con nombre del cliente
        //CONSTRUCTOR
        public Auto(string nom, string mar, byte numPa, bool est, string det, string pro) 
        {
            nombre = nom;
            marca = mar;
            numPasajeros = numPa;
            estandar = est;
            detalles = det;
            propietario = pro;
        }

        //PROPIEDADES
        public string pnombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pmarca
        {
            set { marca = value; }
            get { return marca; }
        }
        public byte pnumPasajeros
        {
            set { numPasajeros = value; }
            get { return numPasajeros; }
        }
        public bool pEstandar //Propiedad de la transmisión 
        {
            set { estandar = value; }
            get { return estandar; } 
        }

        public string pDetalles //Group box con check box
        {
            set { detalles = value; }
            get { return detalles; }
        }
        public string pPropietario
        {
            set { propietario = value; }
            get { return propietario; }
        }
        //TOSTRING
        public override string ToString()
        {
            return string.Format("Nombre: {0} Marca: {1} Número máximo de pasajeros: {2} Transmisión: {3} Detalles: {4} Propietario: {5}",
                this.nombre, this.marca, this.numPasajeros, this.estandar, this.detalles, this.propietario);
        }
    }
}
