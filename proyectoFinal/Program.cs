using EspacioPersonajes;
using EspacioFabricaPersonajes;
using DatosPersonaje;
using CaracteristicasPersonaje;
using System;
using EspecioMenu;
public class Program
{
    public static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Menu.MostrarMenu();
            string? opcion = Console.ReadLine();
            Menu.ManejarOpcion(opcion!);
            if (opcion == "6")
            {
                salir = true;
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
    // public static void Main()
    // {
    //     // Crear un personaje aleatorio utilizando la fábrica de personajes
    //     Personaje personajeAleatorio = FabricaDePersonajes.CrearPersonajeAleatorio();

    //     // Mostrar los datos del personaje creado
    //     Console.WriteLine("Personaje creado:");
    //     Console.WriteLine($"Tipo: {personajeAleatorio.DatosPersonaje.Tipo1}");
    //     Console.WriteLine($"Nombre: {personajeAleatorio.DatosPersonaje.Nombre1}");
    //     Console.WriteLine($"Apodo: {personajeAleatorio.DatosPersonaje.Apodo1}");
    //     Console.WriteLine($"Fecha de Nacimiento: {personajeAleatorio.DatosPersonaje.FechadeNacimiento1}");
    //     Console.WriteLine($"Edad: {personajeAleatorio.DatosPersonaje.Edad1}");
    //     Console.WriteLine($"Salud: {personajeAleatorio.DatosPersonaje.Salud1}");
    //     Console.WriteLine($"Velocidad: {personajeAleatorio.CaracteristicasPersonaje.Velocidad1}");
    //     Console.WriteLine($"Destreza: {personajeAleatorio.CaracteristicasPersonaje.Destreza1}");
    //     Console.WriteLine($"Fuerza: {personajeAleatorio.CaracteristicasPersonaje.Fuerza1}");
    //     Console.WriteLine($"Nivel: {personajeAleatorio.CaracteristicasPersonaje.Nivel1}");
    //     Console.WriteLine($"Armadura: {personajeAleatorio.CaracteristicasPersonaje.Armadura1}");
    //     Console.WriteLine($"Salud: {personajeAleatorio.CaracteristicasPersonaje.Salud1}");
    // }
}
