using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}!");
            Console.ReadKey();
        }
    }
}