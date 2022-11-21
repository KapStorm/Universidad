using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class AdministraReporte
    {
        List<Reporte> servicios = new List<Reporte>();
        public void AgregarReporte(string folio, string numSerie, string ClaveServ, DateTime fecha)
        {
            servicios.Add(new Reporte(folio, numSerie, ClaveServ, fecha));
        }
        public List<string> RegresaFolio()
        {
            List<string> listado = new List<string>();
            foreach (Reporte item in servicios)
            {
                listado.Add(item.pfolio);
            }
            return listado;
        }
        public bool BuscaFolio(string folio)
        {
            bool resultado = false;
            for (int i = 0; i < servicios.Count; i++)
            {
                if (servicios.ElementAt(i).Equals(folio))
                    resultado = true;
            }
            return resultado; ;
        }
        public List<Reporte> RegresaListaServicios()
        {
            return servicios;
        }

        public Reporte RegresaServicio(int i)
        {
            return servicios.ElementAt(i);
        }
        public Reporte RegresaReporte(string folio)
        {
            Reporte rep = null;
            foreach (Reporte item in servicios)
            {
                if(item.pfolio == folio)
                {
                     rep = item;
                }
            }
            return rep;
        }
    }
}
