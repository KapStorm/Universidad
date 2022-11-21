using System.Collections.Generic;
using System.Linq;

namespace Auto
{
    public class AdmServicio
    {
        private Dictionary<string, Servicio> dicServicio;

        public AdmServicio()
        {
            dicServicio = new Dictionary<string, Servicio>();
        }

        public void AgregarServicio(string clave, Servicio servicio)
        {
            dicServicio.Add(clave, servicio);
        }

        public List<Servicio> ObtenerServicios()
        {
            List<Servicio> lista = new List<Servicio>();

            foreach(Servicio servicio in dicServicio.Values)
            {
                lista.Add(servicio);
            }

            return lista;
        }

        public bool ExisteClave(string clave)
        {
            return dicServicio.ContainsKey(clave);
        }

        public Servicio ObtenerServicio(string clave)
        {
            return dicServicio[clave] ?? null;
        }

        public List<string> ObtenerClaves()
        {
            List<string> lista = new List<string>();

            foreach(string clave in dicServicio.Keys)
            {
                lista.Add(clave);
            }
            return lista;
        }
    }
}
