using System;

namespace NumerosEjemplo1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Numero 1: ");
            int numero1 = Int32.Parse(Console.ReadLine() ?? "0");
            Console.Write("Numero 2: ");
            int numero2 = Int32.Parse(Console.ReadLine() ?? "0");

            if (numero1 < numero2) throw new ArithmeticException("El numero 2 debe ser menor al numero 1");

            for (int i = numero2; i <= numero1; i++)
            {
                string esPar = i % 2 == 0 ? "par" : "impar";
                Console.WriteLine($"Valor --> {i}, es {esPar}");
            }

            Console.Write("Ingrese una cadena: ");
            string cadena = Console.ReadLine() ?? "";
            Console.WriteLine(cadena.Length % 2 == 0 ? "Es par" : "Es impar");
            
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}