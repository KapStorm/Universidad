namespace MPS.Entidades
{
    public class Alumno
    {
        private string numeroDeControl;
        private string nombre;
        private string carrera;

        public Alumno(string numeroDeControl, string nombre, string carrera)
        {
            this.numeroDeControl = numeroDeControl;
            this.nombre = nombre;
            this.carrera = carrera;
        }

        public string NumeroDeControl
        {
            get { return numeroDeControl; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Carrera
        {
            get { return carrera; }
        }
    }
}
