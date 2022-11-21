using System;

namespace Choferes.Entidades
{
    public class Chofer
    {
        private string nombres;
        private string apellidos;
        private string numeroLicencia;
        private DateTime fechaVencimientoLicencia;

        public Chofer(string nombres, string apellidos, string numeroLicencia, DateTime fechaVencimientoLicencia)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numeroLicencia = numeroLicencia;
            this.fechaVencimientoLicencia = fechaVencimientoLicencia;
        }

        public string Nombres
        {
            get { return nombres; }
        }

        public string Apellidos
        {
            get { return apellidos; }
        }

        public string NumeroLicencia
        {
            get { return numeroLicencia; }
        }

        public DateTime FechaVencimientoLicencia
        {
            get { return fechaVencimientoLicencia; }
        }
    }
}
