using System;
using System.Collections.Generic;

/*
 * Hecho por: Arellanes Beltran Sebastian
 */
namespace CatalogoDeServicios
{
    public class Utilerias
    {
        // Para pedir un string, validar que no este vacio y
        // retornarlo en mayúscula
        public static string PideString(string mensaje)
        {
            string dato = "";
            // Arreglo con los acentos
            string[] acentos = { "á", "é", "í", "ó", "ú" };
            bool tieneAcentos = true;
            bool tieneCaracteresInvalidos = true;

            // Mientras el dato es vacio, nulo, tiene acentos y tiene caracteres invalidos
            do
            {
                tieneAcentos = false;
                tieneCaracteresInvalidos = false;

                // Aca se lee un dato y lo convetimos a minusculas
                // para poder validar si tiene acentos
                Console.Write(mensaje);
                dato = Console.ReadLine() ?? "";
                dato = dato.ToLower();

                // Checamos si tiene acentos
                foreach (string acento in acentos)
                    if (dato.Contains(acento))
                        tieneAcentos = true;

                // Checamos si tiene caracteres invalidos
                foreach (char caracter in dato)
                    if (!Char.IsLetter(caracter))
                        tieneCaracteresInvalidos = true;
                
            } while (string.IsNullOrEmpty(dato) || tieneAcentos || tieneCaracteresInvalidos);

            // Retornamos el dato en mayusculas
            return dato.ToUpper();
        }

        // Validamos los bytes que se pide por teclado
        public static byte PideByte(string mensaje)
        {
            byte dato = 0;

            // Mientras el dato sea diferente de 0
            do
            {
                // Un try/catch para evitar que lance excepciones
                // con los negativos, strings y mayores a 255
                try
                {
                    Console.Write(mensaje);
                    dato = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception e)
                {
                    dato = 0;
                }
            } while (dato == 0);

            // Retornamos el dato
            return dato;
        }

        // Utileria para el double
        public static double PideDouble(string mensaje)
        {
            double dato = 0;

            // Mientras el dato sea negativo o 0
            do
            {
                Console.Write(mensaje);
                dato = Convert.ToDouble(Console.ReadLine());
            } while (dato <= 0);

            // Retornamos el dato
            return dato;
        }

        // Utileria para imprimir catalogos
        public static void ImprimirCatalogos(List<CatalogoServ> lista)
        {
            // Imprimimos
            foreach (CatalogoServ catalogo in lista)
                Console.WriteLine(catalogo);

            // Checamos si la lista esta vacia
            if (lista.Count == 0)
                Console.WriteLine("No se encontraron catalogos");
        }
    }
}