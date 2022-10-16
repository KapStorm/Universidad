namespace Maestros
{
    internal class Program
    {
        public class Maestro
        {
            private string nombre;
            private double salario;
            private int edad;
            private string numeroDeContol;
            private string rfc;

            public Maestro(string nombre, double salario, int edad, string numeroDeContol, string rfc)
            {
                this.nombre = nombre;
                this.salario = salario;
                this.edad = edad;
                this.numeroDeContol = numeroDeContol;
                this.rfc = rfc;
            }

            public string Nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }

            public double Salario
            {
                get
                {
                    return salario;
                }
                set
                {
                    salario = value;
                }
            }

            public int Edad
            {
                get
                {
                    return edad;
                }
                set
                {
                    edad = value;
                }
            }

            public string NumeroDeContol
            {
                get
                {
                    return numeroDeContol;
                }
            }

            public string Rfc
            {
                get
                {
                    return rfc;
                }
            }
        }
    }
}