using System;

namespace ReadLine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Escriba el primer entero: ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Escriba el segundo entero: ");
                int j = int.Parse(Console.ReadLine());

                int k = i / j;
                Console.WriteLine($"El resultado de divir {i} por {j} es {k}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Excepcion: {e}");
            }

            Console.ReadKey();
        }
    }
}