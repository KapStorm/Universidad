using System;

namespace Auto
{
    public class AutoServicio
    {
        //ATRIBUTOS
        private string numeroAuto;
        private string claveServicio;
        private DateTime fecha;
        private double descuento;

        //CONSTRUCTOR
        public AutoServicio(string numeroAuto, string claveServicio, DateTime fecha, double descuento)
        {
            this.numeroAuto = numeroAuto;
            this.claveServicio = claveServicio;
            this.fecha = fecha;
            this.descuento = descuento;
        }

        public string pNumeroAuto
        {
            get { return numeroAuto; }
            set { numeroAuto = value; }
        }

        public string pClaveServicio
        {
            get { return claveServicio; }
            set { claveServicio = value; }
        }

        public DateTime pFecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public double pDescuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
    }
}
