using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Reporte
    {
        private DateTime Fecha;
        private string folio;
        private string numSerie;
        private string ClaveServ;
        public Reporte(string folio, string numSerie, string ClaveServ, DateTime Fecha)
        {
            this.Fecha = Fecha;
            this.folio = folio;
            this.numSerie = numSerie;
            this.ClaveServ = ClaveServ;
        }
        public DateTime pFecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }

        public string pfolio
        {
            get { return folio; }
            set { folio = value; }
        }

        public string pNumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }

        public string pClaveServ
        {
            get { return ClaveServ; }
            set { ClaveServ = value; }
        }
    }
}
