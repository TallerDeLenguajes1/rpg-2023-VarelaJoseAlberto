using System;
using System.Collections.Generic;
using EspacioPersonajes;
using EspacioFabricaPersonajes;
namespace EspecioMenu
{
    public class Menu
    {
        private static List<Personaje> listaDePersonajes = new List<Personaje>();
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n¡Bienvenido al juego de rol!");
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
            Menu menu = new Menu();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\n¡Has seleccionado crear nuevo personaje!");
                    Personaje personajeAleatorio = FabricaDePersonajes.CrearPersonajeAleatorio();
                    menu.AgregarPersonaje(personajeAleatorio);
                    MostrarDetallesPersonaje(personajeAleatorio);
                    break;
                case "2":
                    Console.WriteLine("\n¡Has seleccionado mostrar detalles del personaje!");
                    menu.MostrarListaPersonajes();
                    break;
                case "3":
                    Console.WriteLine("\n¡Has seleccionado seleccionar otro personaje!");

                    break;
                case "4":
                    Console.WriteLine("\n¡Has seleccionado guardar personaje!");


                    break;
                case "5":
                    Console.WriteLine("\n¡Has seleccionado cargar personaje guardado!");
                    break;
                case "6":
                    Console.WriteLine("\n¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Introduce una opción válida.");
                    break;
            }
        }

        private static void MostrarDetallesPersonaje(Personaje personaje)
        {
            Console.WriteLine("\nPersonaje creado:");
            Console.WriteLine($"Tipo: {personaje.DatosPersonaje.Tipo1}");
            Console.WriteLine($"Nombre: {personaje.DatosPersonaje.Nombre1}");
            Console.WriteLine($"Apodo: {personaje.DatosPersonaje.Apodo1}");
            Console.WriteLine($"Fecha de Nacimiento: {personaje.DatosPersonaje.FechadeNacimiento1}");
            Console.WriteLine($"Edad: {personaje.DatosPersonaje.Edad1}");
            Console.WriteLine($"Salud: {personaje.DatosPersonaje.Salud1}");
            Console.WriteLine($"Velocidad: {personaje.CaracteristicasPersonaje.Velocidad1}");
            Console.WriteLine($"Destreza: {personaje.CaracteristicasPersonaje.Destreza1}");
            Console.WriteLine($"Fuerza: {personaje.CaracteristicasPersonaje.Fuerza1}");
            Console.WriteLine($"Nivel: {personaje.CaracteristicasPersonaje.Nivel1}");
            Console.WriteLine($"Armadura: {personaje.CaracteristicasPersonaje.Armadura1}");
        }

        private void AgregarPersonaje(Personaje personaje)
        {
            listaDePersonajes.Add(personaje);
        }

        private void MostrarListaPersonajes()
        {
            if (listaDePersonajes.Count > 0)
            {
                foreach (var personaje in listaDePersonajes)
                {
                    MostrarDetallesPersonaje(personaje);
                    Console.WriteLine("------------------");
                }
            }
            else
            {
                Console.WriteLine("\nNo hay personajes para mostrar.");
            }
        }

    }
}