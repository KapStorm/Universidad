using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class CatalogoServicio
    {
        private string NombreServicio;
        private double Costo;

        public CatalogoServicio(string NombreServicio,double Costo)
        {
            this.NombreServicio = NombreServicio;
            this.Costo = Costo;
        }
        public string pNombreServicio
        {
            get { return NombreServicio; }
            set { NombreServicio = value; }
        }
        public double pCosto
        {
            get { return Costo; }
            set { Costo = value; }
        }
    }
}
