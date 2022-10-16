using System;
using System.Collections.Generic;

namespace CatalogoDeServicios
{
    public class PresentaCatalogo
    {
        /*
         * Esta clase se va a encargar de interactuar directamente
         * con el usuario, tambien presentara o mostrara
         * la informacion
         */
        private AdministraCatalogo admin;

        public PresentaCatalogo(AdministraCatalogo admin)
        {
            this.admin = admin;
        }

        public void Menu()
        {
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n>=== Menu de Catalogo de Servicios ===<");
                Console.WriteLine("1. Agregar servicio");
                Console.WriteLine("2. Consultar servicio por clave");
                Console.WriteLine("3. Modificar costo del servicio");
                Console.WriteLine("4. Consultar servicio por nombre");
                Console.WriteLine("5. Muestra catalogos");
                Console.WriteLine("6. Imprimir por precio ascendente");
                Console.WriteLine("7. Imprimir alfabeticamente");
                Console.WriteLine("0. Salir");
                Console.Write(">>> ");
                // Para evitar que el usuario escriba algo no valido y no interrumpir
                // el programa
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    opcion = -1;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarServicio();
                        break;
                    case 2:
                        ConsultarServicioPorClave();
                        break;
                    case 3:
                        ModificarCosto();
                        break;
                    case 4:
                        ConsultarServicioPorNombre();
                        break;
                    case 5:
                        MuestraCatalogo();
                        break;
                    case 6:
                        ImprimirPorPrecioAscendente();
                        break;
                    case 7:
                        ImprimeAlfabeticamente();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

                Console.WriteLine("Presione el teclado para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("Saliendo de la APP");
            Console.ReadKey();
        }

        // Metodo para pedir datos y agregar al arreglo
        private void AgregarServicio()
        {
            // Pedir datos
            // Mandar guardar en el arreglo
            Console.WriteLine("\n=== Agregar servicio ===");
            if (admin.ChecarArregloLleno())
                Console.WriteLine("Arreglo lleno");
            else
            {
                byte claveServicio = Utilerias.PideByte("Clave del servicio: ");

                if (admin.ConsultarServicio(claveServicio) != null)
                {
                    Console.WriteLine("Clave ya introducida");
                }
                else
                {
                    string nombreServicio = Utilerias.PideString("Nombre del servicio: ");
                    double costo = Utilerias.PideDouble("Costo del servicio: $");

                    bool res = admin.AgregaServicio(claveServicio, nombreServicio, costo);

                    if (res)
                        Console.WriteLine($"Servicio {claveServicio} agregado con exito");
                    else
                        Console.WriteLine($"Error al agregar el servicio {claveServicio}, arreglo lleno");
                }
            }
        }

        private void ConsultarServicioPorClave()
        {
            Console.WriteLine("\n=== Consula de servicio por clave ===");
            Console.Write("Clave del servicio: ");
            byte claveServicio = Convert.ToByte(Console.ReadLine());

            CatalogoServ catalogo = admin.ConsultarServicio(claveServicio);

            if (catalogo == null)
                Console.WriteLine($"No se encontro un catalogo con la clave {claveServicio}");
            else
            {
                Console.WriteLine("Catalogo encontrado");
                Console.WriteLine(catalogo);
            }
        }

        private void ModificarCosto()
        {
            Console.WriteLine("\n=== Modificar Costo ===");
            byte claveServicio = Utilerias.PideByte("Clave del servicio: ");

            double costo = Utilerias.PideDouble("A que costo va a cambiarlo: $");

            bool valido = admin.ModificarCosto(claveServicio, costo);

            if (valido)
                Console.WriteLine($"Servicio {claveServicio} modificado a ${costo} con exito");
            else
                Console.WriteLine($"Error al encontrar el servicio {claveServicio}");
        }

        private void ConsultarServicioPorNombre()
        {
            Console.WriteLine("\n=== Consulta de servicio por nombre ===");
            string nombreServicio = Utilerias.PideString("Nombre del servicio: ");

            CatalogoServ[] catalogos = admin.BuscarPorNombre(nombreServicio);

            Console.WriteLine("Resultados");

            foreach (CatalogoServ catalogo in catalogos)
                if (catalogo != null)
                    Console.WriteLine(catalogo);

            if (catalogos.Length == 0)
                Console.WriteLine($"No se encontro ningun catalogo con el nombre {nombreServicio}");
        }

        private void MuestraCatalogo()
        {
            Console.WriteLine("\n=== Mostrar catalogos ===");
            List<CatalogoServ> listado = admin.ListadoServicios();

            foreach (CatalogoServ item in listado)
                Console.WriteLine(item);

            if (listado.Count == 0)
                Console.WriteLine("No hay catalogos");
        }

        private void ImprimirPorPrecioAscendente()
        {
            Console.WriteLine("\n=== Imprimir por precio ascendente ===");
            List<CatalogoServ> lista = admin.ImprimirPorPrecioAscendente();

            foreach (CatalogoServ catalogo in lista)
                Console.WriteLine(catalogo);

            if (lista.Count == 0)
                Console.WriteLine("No se encontraron catalogos");
        }

        private void ImprimeAlfabeticamente()
        {
            Console.WriteLine("\n=== Imprimir alfabeticamente===");
            List<CatalogoServ> lista = admin.ImprimeAlfabeticamente();

            foreach (CatalogoServ catalogo in lista)
                Console.WriteLine(catalogo);

            if (lista.Count == 0)
                Console.WriteLine("No se encontraron catalogos");
        }
    }
}