using System;

namespace ArregloEscuela
{
    internal class Program
    {
        private double[] ahorroAlumnos;

        public Program()
        {
            ahorroAlumnos = new double[20];
        }

        public static void Main(string[] args)
        {
            new Program().Menu();
        }

        public void Menu()
        {
            Console.WriteLine("\n=== Menu ===");
            Console.WriteLine("1. Agregar ahorro");
            Console.WriteLine("2. Mostrar ahorros");
            Console.WriteLine("3. Mostrar monto total ahorrado del grupo");
            Console.WriteLine("4. Mostrar el ahoro de un niño");
            Console.WriteLine("5. Obtener el ahorro mayor");
            Console.WriteLine("6. Restar ahorro");
            Console.WriteLine("0. Salir");
            Console.Write(">>> ");
            int opcion = Int32.Parse(Console.ReadLine() ?? "0");
            switch (opcion)
            {
                case 1:
                    AgregarAhorro();
                    break;
                case 2:
                    MostrarAhorrosIndividuales();
                    break;
                case 3:
                    MostrarMontoTotalGrupo();
                    break;
                case 4:
                    MostrarAhorroIndividual();
                    break;
                case 5:
                    ObtenerAhorroMayor();
                    break;
                case 6:
                    RestarAhorro();
                    break;
                case 0:
                    return;
            }
            
            Menu();
        }

        public void AgregarAhorro()
        {
            int id = PedirId();

            Console.Write("¿Cuánto desea ahorrar? ");
            double ahorro = Double.Parse(Console.ReadLine() ?? "0");

            if (ahorro <= 0)
            {
                Console.WriteLine("No se puede ahorrar 0 o negativo");
                return;
            }

            ahorroAlumnos[id] += ahorro;
            Console.WriteLine($"El ahorro de {id + 1} se actualizo a {ahorroAlumnos[id]}");
        }

        public void MostrarAhorrosIndividuales()
        {
            int index = 1;

            foreach (double value in ahorroAlumnos)
            {
                Console.WriteLine($"{index} lleva ahorrado {value}");
                index++;
            }
        }

        public void MostrarMontoTotalGrupo()
        {
            double total = 0;

            foreach (double value in ahorroAlumnos)
            {
                total += value;
            }

            Console.WriteLine($"El total del grupo es {total}");
        }

        public void MostrarAhorroIndividual()
        {
            int id = PedirId();

            Console.WriteLine($"El alumno {id + 1} ha ahorrado {ahorroAlumnos[id]}");
        }

        public void ObtenerAhorroMayor()
        {
            double mayor = Double.MinValue;
            int id = 0;
            int index = 0;

            foreach (double value in ahorroAlumnos)
            {
                if (value > mayor)
                {
                    mayor = value;
                    id = index;
                }
                
                index++;
            }

            Console.WriteLine($"El alumno {id + 1} tiene el mayor ahorro con {mayor}");
        }

        public void RestarAhorro()
        {
            int id = PedirId();

            Console.Write("¿Cuánto desea restarle al ahorro? ");
            double ahorro = Double.Parse(Console.ReadLine() ?? "0");

            if (ahorro <= 0)
            {
                Console.WriteLine("No se puede restar 0 o negativo");
                return;
            }

            if (ahorroAlumnos[id] < ahorro)
            {
                Console.WriteLine("No se puede restar más de lo que tiene el niño");
                return;
            }

            ahorroAlumnos[id] -= ahorro;
            Console.WriteLine($"El ahorro de {id + 1} se actualizo a {ahorroAlumnos[id]}");
        }

        public int PedirId()
        {
            Console.Write("Ingrese el ID del alumno (1-20): ");
            int id = Int32.Parse(Console.ReadLine() ?? "0");
            
            if (0 >= id || id > 20)
            {
                Console.WriteLine("Id erroneo, vuelva a ingresar el id");
                return PedirId();
            }

            return id - 1; // Menos 1 para la posicion del areglo
        }
    }
}