using System;
using System.Collections.Generic;
using System.Linq;

namespace StringEjemplo1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Un string:");
            string str = Console.ReadLine() ?? "";

            List<char> vocales = "aeiou".ToList();
            str.ToList()
                .Where(x => vocales.Contains(char.ToLower(x))).ToList()
                .ForEach(Console.Write);
        }
    }
}