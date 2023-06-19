using System;
namespace EspecioMenu
{


    public class Menu
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenido al juego de rol!");
            Console.WriteLine("1. Crear nuevo personaje");
            Console.WriteLine("2. Mostrar detalles del personaje");
            Console.WriteLine("3. Seleccionar otro personaje");
            Console.WriteLine("4. Guardar personaje");
            Console.WriteLine("5. Cargar personaje guardado");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");
        }

        public static void ManejarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("¡Has seleccionado crear nuevo personaje!");

                    break;
                case "2":
                    Console.WriteLine("¡Has seleccionado mostrar detalles del personaje!");

                    break;
                case "3":
                    Console.WriteLine("¡Has seleccionado seleccionar otro personaje!");

                    break;
                case "4":
                    Console.WriteLine("¡Has seleccionado guardar personaje!");
                    break;
                case "5":
                    Console.WriteLine("¡Has seleccionado cargar personaje guardado!");
                    break;
                case "6":
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Introduce una opción válida.");
                    break;
            }
        }
    }
}