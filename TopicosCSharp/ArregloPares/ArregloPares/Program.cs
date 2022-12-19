using System;
using System.Collections.Generic;
using System.IO;

namespace ArregloPares
{
    /*
     * Hacer un porgama que llene un arreglo con 10 elementos
     * impares.
     * Hay que utilizar el operador %
     */
    internal class Program
    {
        private List<int> numeros;

        // Constructor para incializar la lista de numeros
        public Program()
        {
            numeros = new List<int>();
        }

        public static void Main(string[] args)
        {
            // Instancia de la clase y ejecucion
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.ReadKey();
        }

        // En este metodo hace que el usuario tenga que ingresar
        // 10 numeros
        public void Ejecutar()
        {
            Console.WriteLine("La app solo admite numeros IMPARES");
            // Ciclo while mientras el tamaño del arreglo es diferente de 10
            while (numeros.Count != 10)
            {
                numeros.Add(PedirNumero());
            }

            // Es como un foreach pero usando programacion
            // funcional: for (int i: numeros)
            numeros.ForEach(x => Console.Write($"{x} "));
        }
        
        // Pide el numero y lo valida con el metodo ValidarImpar
        public int PedirNumero()
        {
            Console.Write("Ingrese un numero: ");
            return ValidarImpar(int.Parse(Console.ReadLine() ?? "0"));
        }

        // En este metodo si el numero es par, entonces hace una llamada
        // al metodo PedirNumero para volver a leer un numero
        public int ValidarImpar(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} es par");
                n = PedirNumero();
            }

            return n;
        }
    }
}