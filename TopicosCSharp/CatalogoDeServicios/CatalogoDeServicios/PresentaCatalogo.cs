using System;
using System.Collections.Generic;

/*
 * Hecho por: Arellanes Beltran Sebastian
 */
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

        // Menu para poder pedir una opcion e invocar el metodo de la opcion
        public void Menu()
        {
            byte opcion = 0;

            do
            {
                Console.WriteLine("\n>=== Menu de Catalogo de Servicios ===<");
                Console.WriteLine("1. Agregar servicio");
                Console.WriteLine("2. Consultar servicio por clave");
                Console.WriteLine("3. Modificar costo del servicio");
                Console.WriteLine("4. Consultar servicio por nombre");
                Console.WriteLine("5. Muestra catalogos");
                Console.WriteLine("6. Imprimir por precio ascendente");
                Console.WriteLine("7. Imprimir alfabeticamente");
                Console.WriteLine("10. Salir");
                Console.Write(">>> ");
                // Para evitar que el usuario escriba algo no valido y no interrumpir
                // el programa
                opcion = Utilerias.PideByte("");

                // Switch para los metodos segun el menu
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
                        MuestraCatalogos();
                        break;
                    case 6:
                        ImprimirPorPrecioAscendente();
                        break;
                    case 7:
                        ImprimeAlfabeticamente();
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 10);

            // Se ejecuta cuando termina el do while
            Console.WriteLine("Saliendo de la APP");
            Console.ReadKey();
        }

        // Metodo para pedir datos y agregar al arreglo
        private void AgregarServicio()
        {
            // Pedir datos
            // Mandar guardar en el arreglo
            Console.WriteLine("\n=== Agregar servicio ===");
            
            // Checar si el arreglo esta lleno
            if (admin.ChecarArregloLleno())
                Console.WriteLine("Arreglo lleno");
            else
            {
                // Si no esta lleno pedimos los datos
                byte claveServicio = Utilerias.PideByte("Clave del servicio: ");

                // Checar si el servicio con la clave ya existe
                if (admin.ConsultarServicio(claveServicio) != null)
                {
                    Console.WriteLine("Clave ya introducida");
                }
                else
                {
                    // Si no existe seguimos pidiendod atos
                    string nombreServicio = Utilerias.PideString("Nombre del servicio: ");
                    double costo = Utilerias.PideDouble("Costo del servicio: $");

                    // Lo agregamos y retorna si se realizo el servicio
                    bool res = admin.AgregaServicio(claveServicio, nombreServicio, costo);

                    if (res)
                        Console.WriteLine($"Servicio {claveServicio} agregado con exito");
                    else
                        Console.WriteLine($"Error al agregar el servicio {claveServicio}, arreglo lleno");
                }
            }
        }

        // Consulta los servicios por clave
        private void ConsultarServicioPorClave()
        {
            Console.WriteLine("\n=== Consula de servicio por clave ===");
            // Pedimos la clave
            Console.Write("Clave del servicio: ");
            byte claveServicio = Utilerias.PideByte("Clave del servicio: ");

            // Buscamos el servicio
            CatalogoServ catalogo = admin.ConsultarServicio(claveServicio);

            // Si el servicio no existe
            if (catalogo == null)
                Console.WriteLine($"No se encontro un catalogo con la clave {claveServicio}");
            else // Si el servicio si existe, imprime el catalogo   
            {
                Console.WriteLine("Catalogo encontrado");
                Console.WriteLine(catalogo);
            }
        }

        // Modifica el costo de un servicio
        private void ModificarCosto()
        {
            Console.WriteLine("\n=== Modificar Costo ===");
            // Pedimos la clave del servicio
            byte claveServicio = Utilerias.PideByte("Clave del servicio: ");
            
            // Si la clave no se encuentra (-1 es por si no encontro)
            if (admin.BuscarClavePos(claveServicio) == -1)
                Console.WriteLine("La clave no existe");
            else
            {
                // Si la clave si existe, pedimos los datos
                double costo = Utilerias.PideDouble("A que costo va a cambiarlo: $");

                // Cambiamos el precio que retorna un bool
                bool valido = admin.ModificarCosto(claveServicio, costo);

                // Imprimir si se realizo exitosamente
                if (valido)
                    Console.WriteLine($"Servicio {claveServicio} modificado a ${costo} con exito");
                else
                    Console.WriteLine($"Error al encontrar el servicio {claveServicio}");
            }
        }

        // Consultamos todos los servicios por nombre
        private void ConsultarServicioPorNombre()
        {
            Console.WriteLine("\n=== Consulta de servicio por nombre ===");
            // Pedimos el nombre
            string nombreServicio = Utilerias.PideString("Nombre del servicio: ");

            // Obtenemos una lista con todos los catalogos que tienen el nombre
            List<CatalogoServ> lista = admin.BuscarPorNombre(nombreServicio);

            // Imprimimos los catalogos
            Utilerias.ImprimirCatalogos(lista);
        }

        // Muestra todos los catalogos
        private void MuestraCatalogos()
        {
            Console.WriteLine("\n=== Mostrar catalogos ===");
            // Obtenemos todos los catalogos
            List<CatalogoServ> lista = admin.ListadoServicios();

            // Imprimimos los catalogos
            Utilerias.ImprimirCatalogos(lista);
        }

        // Imprime los catalogos por precio
        private void ImprimirPorPrecioAscendente()
        {
            Console.WriteLine("\n=== Imprimir por precio ascendente ===");
            // Obtenemos los catalogos por precio
            List<CatalogoServ> lista = admin.ImprimirPorPrecioAscendente();

            // Imprimimos los catalogos
            Utilerias.ImprimirCatalogos(lista);
        }

        // Imprime los catalogos alfabeticamente
        private void ImprimeAlfabeticamente()
        {
            Console.WriteLine("\n=== Imprimir alfabeticamente ===");
            // Obtenemos los catalogos alfabeticamente
            List<CatalogoServ> lista = admin.ImprimeAlfabeticamente();

            // Imprimimos los catalogos
            Utilerias.ImprimirCatalogos(lista);
        }
    }
}