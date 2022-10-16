namespace CatalogoDeServicios
{
    public class CatalogoServ
    {
        private byte claveServicio;
        private string nombreServicio;
        private double costo;

        public CatalogoServ(byte claveServicio, string nombreServicio, double costo)
        {
            this.claveServicio = claveServicio;
            this.nombreServicio = nombreServicio;
            this.costo = costo;
        }

        public byte ClaveServicio
        {
            get { return claveServicio; }
        }

        public string NombreServicio
        {
            get { return nombreServicio; }
            set { nombreServicio = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public override string ToString()
        {
            return $"Clave: {claveServicio}; Nombre: {nombreServicio}; Costo: ${costo}";
        }
    }
}