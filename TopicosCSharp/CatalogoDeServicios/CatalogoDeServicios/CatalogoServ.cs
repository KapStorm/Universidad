/*
 * Hecho por: Arellanes Beltran Sebastian
 */
namespace CatalogoDeServicios
{
    public class CatalogoServ
    {
        // Atributos de la clase
        private byte claveServicio;
        private string nombreServicio;
        private double costo;

        // Constructor con todos los atributos
        public CatalogoServ(byte claveServicio, string nombreServicio, double costo)
        {
            this.claveServicio = claveServicio;
            this.nombreServicio = nombreServicio;
            this.costo = costo;
        }

        // Propiedad de ClaveServicio
        public byte ClaveServicio
        {
            get { return claveServicio; }
        }

        // Propiedad de NombreServicio
        public string NombreServicio
        {
            get { return nombreServicio; }
            set { nombreServicio = value; }
        }

        // Propiedad de Costo
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        // Metodo sobrescrito to string
        public override string ToString()
        {
            return $"Clave: {claveServicio}; Nombre: {nombreServicio}; Costo: ${costo}";
        }
    }
}