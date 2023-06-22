using EspacioPersonajes;
using EspacioCombate;
using EspacioFabricaPersonajes;
using EspacioPersonajesJson;

namespace EspecioMenu
{
    public class Menu
    {
        private static List<Personaje> listaDePersonajes = new List<Personaje>();
        private static string archivoJson = "personajes.json";

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n¡Bienvenido al juego de rol!");
            Console.WriteLine("1. Crear nuevo personaje");
            Console.WriteLine("2. Mostrar detalles del personaje");
            Console.WriteLine("3. Seleccionar otro personaje");
            Console.WriteLine("4. Combate");
            Console.WriteLine("5. Cargar personaje guardado");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");
        }

        public static void ManejarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\n¡Has seleccionado crear nuevo personaje!");
                    // Verificar si existe el archivo de personajes
                    if (PersonajesJson.Existe(archivoJson))
                    {
                        // Si existe y tiene datos, cargar los personajes desde el archivo
                        listaDePersonajes = PersonajesJson.LeerPersonajes(archivoJson);
                        Console.WriteLine("Ya fueron creados los 10 personajes");
                    }
                    else
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Personaje personajeAleatorio = FabricaDePersonajes.CrearPersonajeAleatorio();
                            listaDePersonajes.Add(personajeAleatorio);
                        }
                        PersonajesJson.GuardarPersonajes(listaDePersonajes, archivoJson);
                    }
                    // Console.Write("¿Deseas guardar este personaje? (S/N): ");
                    // string respuesta = Console.ReadLine();
                    // if (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase))
                    // {
                    //     listaDePersonajes.Add(personajeAleatorio);
                    //     GuardarPersonaje();
                    //     Console.WriteLine("Personaje guardado exitosamente.");
                    // }
                    break;
                case "2":
                    Console.WriteLine("\n¡Has seleccionado mostrar detalles del personaje!");
                    MostrarListaPersonajes();
                    break;
                case "3":
                    Console.WriteLine("\n¡Has seleccionado seleccionar otro personaje!");
                    CargarPersonajes();
                    break;
                case "4":
                    Console.WriteLine("\n¡Has seleccionado Combate!");
                    Console.WriteLine("Ingrese el primer personaje:");
                    Personaje personaje1 = ObtenerPersonajeDesdeInteraccionUsuario();

                    Console.WriteLine("Ingrese el segundo personaje:");
                    Personaje personaje2 = ObtenerPersonajeDesdeInteraccionUsuario();

                    Combate.IniciarCombate(personaje1, personaje2);
                    break;
                case "5":
                    Console.WriteLine("\n¡Has seleccionado cargar personaje guardado!");
                    CargarPersonajes();
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
            if (personaje != null)
            {
                Console.WriteLine("\nPersonaje creado:");
                Console.WriteLine($"Tipo: {personaje.DatosPersonaje?.Tipo1}");
                Console.WriteLine($"Nombre: {personaje.DatosPersonaje?.Nombre1}");
                Console.WriteLine($"Apodo: {personaje.DatosPersonaje?.Apodo1}");
                Console.WriteLine($"Fecha de Nacimiento: {personaje.DatosPersonaje?.FechadeNacimiento1}");
                Console.WriteLine($"Edad: {personaje.DatosPersonaje?.Edad1}");
                Console.WriteLine($"Velocidad: {personaje.CaracteristicasPersonaje?.Velocidad1}");
                Console.WriteLine($"Destreza: {personaje.CaracteristicasPersonaje?.Destreza1}");
                Console.WriteLine($"Fuerza: {personaje.CaracteristicasPersonaje?.Fuerza1}");
                Console.WriteLine($"Nivel: {personaje.CaracteristicasPersonaje?.Nivel1}");
                Console.WriteLine($"Armadura: {personaje.CaracteristicasPersonaje?.Armadura1}");
                Console.WriteLine($"Salud: {personaje.CaracteristicasPersonaje?.Salud1}");
                Console.WriteLine($"Precisión: {personaje.CaracteristicasPersonaje?.Precision1}");
                Console.WriteLine($"Evasión: {personaje.CaracteristicasPersonaje?.Evasion}");

            }
            else
            {
                Console.WriteLine("\nEl personaje es nulo.");
            }
        }


        private static void MostrarListaPersonajes()
        {
            if (listaDePersonajes.Count == 0)
            {
                Console.WriteLine("No se han creado personajes.");
                return;
            }

            Console.WriteLine("\nLista de personajes:");
            for (int i = 0; i < listaDePersonajes.Count; i++)
            {
                Console.WriteLine($"Personaje {i + 1}: {listaDePersonajes[i].DatosPersonaje?.Nombre1}");
            }

            int numeroPersonaje;
            do
            {
                Console.WriteLine("Ingresa el número del personaje para ver detalles (0 para salir):");
                string? indice = Console.ReadLine();
                if (int.TryParse(indice, out numeroPersonaje))
                {
                    if (numeroPersonaje >= 1 && numeroPersonaje <= listaDePersonajes.Count)
                    {
                        MostrarDetallesPersonaje(listaDePersonajes[numeroPersonaje - 1]);
                        break;
                    }
                    else if (numeroPersonaje == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Número de personaje inválido. Introduce un número válido.");
            } while (true);
        }

        private static void GuardarPersonaje()
        {
            PersonajesJson.GuardarPersonajes(listaDePersonajes, archivoJson);
        }

        private static void CargarPersonajes()
        {
            if (PersonajesJson.Existe(archivoJson))
            {
                listaDePersonajes = PersonajesJson.LeerPersonajes(archivoJson);
                Console.WriteLine("Personajes cargados exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún archivo de personajes guardados.");
            }
        }
        private static Personaje ObtenerPersonajeDesdeInteraccionUsuario()
        {
            if (listaDePersonajes.Count == 0)
            {
                Console.WriteLine("No se han creado personajes.");
            }

            Console.WriteLine("Selecciona un personaje:");

            for (int i = 0; i < listaDePersonajes.Count; i++)
            {
                Console.WriteLine($"Personaje {i + 1}: {listaDePersonajes[i].DatosPersonaje?.Nombre1}");
            }
            int numeroPersonaje;
            do
            {
                Console.Write("Ingresa el número del personaje: ");
                string? indice = Console.ReadLine();
                if (int.TryParse(indice, out numeroPersonaje))
                {
                    if (numeroPersonaje >= 1 && numeroPersonaje <= listaDePersonajes.Count)
                    {
                        return listaDePersonajes[numeroPersonaje - 1];
                    }
                }
                Console.WriteLine("Número de personaje inválido. Introduce un número válido.");
            } while (true);
        }

    }

}
