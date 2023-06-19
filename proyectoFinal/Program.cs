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


}
