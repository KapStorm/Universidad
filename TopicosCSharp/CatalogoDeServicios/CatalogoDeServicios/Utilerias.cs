using System;

namespace CatalogoDeServicios
{
    public class Utilerias
    {
        // Para pedir un string, validar que no este vacio y
        // retornarlo en mayúscula
        public static string PideString(string mensaje)
        {
            string dato = "";
            string[] acentos = { "á", "é", "í", "ó", "ú" };
            bool tieneAcentos = true;

            do
            {
                tieneAcentos = false;

                Console.Write(mensaje);
                dato = Console.ReadLine();

                foreach (string acento in acentos)
                    if (dato != null && dato.Contains(acento))
                        tieneAcentos = true;
            } while (string.IsNullOrEmpty(dato) || tieneAcentos);

            return dato.ToUpper();
        }

        public static byte PideByte(string mensaje)
        {
            byte dato = 0;

            do
            {
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

            return dato;
        }

        public static double PideDouble(string mensaje)
        {
            double dato = 0;

            do
            {
                Console.Write(mensaje);
                dato = Convert.ToDouble(Console.ReadLine());
            } while (dato <= 0);

            return dato;
        }
    }
}