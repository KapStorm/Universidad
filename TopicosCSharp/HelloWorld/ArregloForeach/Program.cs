using System;

namespace ArregloForeach
{
    internal class Program
    {
        private string[] arreglos;
        private int pos;

        public Program()
        {
            arreglos = new string[10];
            pos = 0;
        }
        
        public static void Main(string[] args)
        {
            Program p = new Program();
            int opcion;
            do
            {
                Console.WriteLine("\n\t===MENU===");
                Console.WriteLine("1. Pide elemento");
                Console.WriteLine("2. Imprime elemntos");
                Console.WriteLine("3. Imprime elementos en MAYUSCULA");
                Console.WriteLine("4. Imprime elementos en minuscula");
                Console.WriteLine("0. Salir");
                Console.Write(">>> ");
                opcion = Int32.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1:
                        p.PideElemento();
                        break;
                    case 2:
                        p.MuestaElementos();
                        break;
                    case 3:
                        p.MuestraElementosMayus();
                        break;
                    case 4:
                        p.MuestraElementosMinus();
                        break;
                }
            } while (opcion != 0);
        }

        public void PideElemento()
        {
            if (pos == arreglos.Length)
            {
                Console.WriteLine("Arreglo lleno");
                return;
            }

            Console.Write("Elemento a agregar: ");
            arreglos[pos] = Console.ReadLine();
            pos++;
        }

        public void MuestaElementos()
        {
            Console.WriteLine("Imprimiendo elementos");
            foreach (string item in arreglos)
            {
                if (item != null)
                    Console.WriteLine($"Elemento ${item}");
            }
        }

        public void MuestraElementosMayus()
        {
            Console.WriteLine("Imprimiendo elementos en MAYUSCULA");
            foreach (string item in arreglos)
            {
                if (item != null)
                    Console.WriteLine($"Elemento ${item.ToUpper()}");
            }
        }

        public void MuestraElementosMinus()
        {
            Console.WriteLine("Imprimiendo elementos en minuscula");
            foreach (string item in arreglos)
            {
                if (item != null)
                    Console.WriteLine($"Elemento {item.ToLower()}");
            }
        }
    }
}