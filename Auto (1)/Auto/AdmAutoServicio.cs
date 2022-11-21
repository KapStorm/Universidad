using System;
using System.Collections.Generic;

namespace Auto
{
    public class AdmAutoServicio
    {
        private Dictionary<string, AutoServicio> dicAutoServicio = new Dictionary<string, AutoServicio>(); //Dictionary de Servicios

        //Metodo para agregar el servicio a disctionary
        public void AgregaServ(string folio, string numeroAuto, string claveServicio, DateTime fecha, double descuento)
        {
            dicAutoServicio.Add(folio, new AutoServicio(numeroAuto, claveServicio, fecha, descuento));
        }

        //Identificar Claves iguales
        public bool DuplicidadClv(string clv)
        {
            return dicAutoServicio.ContainsKey(clv);
        }

        //Metodo Retorna un list con elementos del dictionary
        public List<AutoServicio> ListaServicio()
        {
            List<AutoServicio> Servicios = new List<AutoServicio>();
            foreach (AutoServicio elemento in this.dicAutoServicio.Values)
            {
                Servicios.Add(elemento);
            }
            return Servicios;
        }

        //Metodo verifica string Vacio 
        public bool VerificaVacio(string campo)
        {
            bool retorno = false;
            if (string.IsNullOrEmpty(campo))
            {
                retorno = true;
            }
            return retorno;
        }

        //Metodo que retorna las claves de los servicios
        public List<string> ListaClv()
        {
            List<string> ListaClaves = new List<string>();
            foreach (string elemento in dicAutoServicio.Keys)
            {
                ListaClaves.Add(elemento);
            }
            return ListaClaves;
        }

        //Metodo que retorna la clave de nuestro servicio 
        public AutoServicio Clave(string clv)
        {
            return dicAutoServicio[clv];
        }
    }
}
