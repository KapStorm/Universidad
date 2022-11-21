namespace Choferes.Entidades
{
    public class Visitante
    {
        private string nombres;
        private string apellidos;
        private int edad;

        public Visitante(string nombres, string apellidos, int edad)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public string Nombres
        {
            get { return nombres; }
        }

        public string Apellidos
        {
            get { return apellidos; }
        }

        public int Edad
        {
            get { return edad; }
        }
    }
}
