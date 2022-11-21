namespace Auto
{
    public class Servicio
    {
        private string nombre;
        private string descripcion;
        private double costo;

        public Servicio(string nombre, string descripcion, double costo)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.costo = costo;
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string pDescripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double pCosto
        {
            get { return costo; }
            set { costo = value; }
        }
    }
}
