using System;

namespace Choferes.Entidades
{
    public class Visita
    {
        private int chofer;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int numeroPersonas;
        private char tipoEvento;
        private string descripcionEvento;
        private string ciudadDestino;

        public Visita(int chofer, DateTime fechaInicio, DateTime fechaFin, int numeroPersonas, char tipoEvento, string descripcionEvento, string ciudadDestino)
        {
            this.chofer = chofer;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.numeroPersonas = numeroPersonas;
            this.tipoEvento = tipoEvento;
            this.descripcionEvento = descripcionEvento;
            this.ciudadDestino = ciudadDestino;
        }

        public int Chofer
        {
            get { return chofer; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        public int NumeroPersonas 
        { 
            get { return numeroPersonas; } 
        }

        public char TipoEvento
        {
            get { return tipoEvento; }
        }

        public string DescripcionEvento
        {
            get { return descripcionEvento; }
        }

        public string CiudadDestino
        {
            get { return ciudadDestino; }
        }
    }
}
