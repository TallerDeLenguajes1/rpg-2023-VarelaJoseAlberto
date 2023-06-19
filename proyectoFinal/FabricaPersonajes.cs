using EspacioPersonajes;
using DatosPersonaje;
using CaracteristicasPersonaje;
using System;
namespace EspacioFabricaPersonajes
{
    public class FabricaDePersonajes
    {
        public static Personaje CrearPersonajeAleatorio()
        {
            // Crea un objeto Personaje con datos aleatorios
            Random random = new Random();
            // Personaje personaje = new Personaje();

            // Genera valores aleatorios para las características
            Datos datosPersonaje = new Datos(
                ObtenerTipoAleatorio(),
                ObtenerNombreAleatorio(),
                ObtenerApodoAleatorio(),
                ObtenerFechaNacimientoAleatoria(),
                random.Next(0, 301),
                100.0
            );

            Caracteristicas CaracteristicasPersonaje = new Caracteristicas(
                random.Next(1, 11),
                random.Next(1, 6),
                random.Next(1, 11),
                random.Next(1, 11),
                random.Next(1, 11),
                100
            );
            Personaje personaje = new Personaje(datosPersonaje, CaracteristicasPersonaje);
            return personaje;
        }

        // Aquí puedes agregar métodos auxiliares para generar datos aleatorios, como tipos, nombres, apodos, etc.
        private static string ObtenerTipoAleatorio()
        {
            string[] tipos = { "Guerrero", "Mago", "Arquero" };
            Random random = new Random();
            int index = random.Next(tipos.Length);
            return tipos[index];
        }
        private static string ObtenerNombreAleatorio()
        {
            string[] nombres = { "Gandalf", "Aragorn", "Legolas", "Frodo", "Gimli", "Gandalf", "Gollum", "Bilbo" };
            Random random = new Random();
            int index = random.Next(nombres.Length);
            return nombres[index];
        }

        private static string ObtenerApodoAleatorio()
        {
            string[] apodos = { "El Valiente", "El Sabio", "El Veloz", "El Poderoso", "El Oscuro" };
            Random random = new Random();
            int index = random.Next(apodos.Length);
            return apodos[index];
        }

        private static DateTime ObtenerFechaNacimientoAleatoria()
        {
            Random random = new Random();
            int year = random.Next(1900, DateTime.Now.Year);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month));
            return new DateTime(year, month, day);
        }
    }
}