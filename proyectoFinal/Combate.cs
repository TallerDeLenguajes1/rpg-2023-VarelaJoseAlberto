using EspacioPersonajes;
using System;

namespace EspacioCombate
{
    public class Combate
    {
        public static void IniciarCombate(Personaje personaje1, Personaje personaje2)
        {
            Console.WriteLine("¡Comienza el combate!");
            Console.WriteLine();

            Personaje atacante = personaje1;
            Personaje defensor = personaje2;

            while (personaje1.CaracteristicasPersonaje.Salud1 > 0 && personaje2.CaracteristicasPersonaje.Salud1 > 0)
            {
                RealizarTurno(atacante, defensor);
                // Intercambia los roles de atacante y defensor para el siguiente turno
                (atacante, defensor) = (defensor, atacante);
                personaje1 = atacante;
                personaje2 = defensor;
            }

            Personaje ganador = personaje1.CaracteristicasPersonaje.Salud1 > 0 ? personaje1 : personaje2;
            Personaje perdedor = personaje1.CaracteristicasPersonaje.Salud1 <= 0 ? personaje1 : personaje2;

            Console.WriteLine();
            Console.WriteLine($"¡{ganador.DatosPersonaje.Nombre1} ha ganado el combate y ha obtenido el Trono de Hierro!");
            Console.WriteLine();
            Console.WriteLine("Datos del ganador:");
            Console.WriteLine($"Nombre: {ganador.DatosPersonaje.Nombre1}");
            Console.WriteLine($"Nivel: {ganador.CaracteristicasPersonaje.Nivel1}");
            Console.WriteLine($"Salud: {ganador.CaracteristicasPersonaje.Salud1}");
            Console.WriteLine($"Fuerza: {ganador.CaracteristicasPersonaje.Fuerza1}");
            Console.WriteLine($"Destreza: {ganador.CaracteristicasPersonaje.Destreza1}");
            Console.WriteLine($"Armadura: {ganador.CaracteristicasPersonaje.Armadura1}");
            Console.WriteLine($"Velocidad: {ganador.CaracteristicasPersonaje.Velocidad1}");
            Console.WriteLine($"Precisión: {ganador.CaracteristicasPersonaje.Precision1}");
            Console.WriteLine($"Evasión: {ganador.CaracteristicasPersonaje.Evasion}");

            // Aplica una mejora en las habilidades al personaje ganador
            ganador.CaracteristicasPersonaje.Salud1 += 10; // Ejemplo: +10 en salud
            ganador.CaracteristicasPersonaje.Defensa1 += 5; // Ejemplo: +5 en defensa

            Console.WriteLine();
            Console.WriteLine($"{ganador.DatosPersonaje.Nombre1} ha obtenido una mejora en sus habilidades.");
            Console.WriteLine();
            Console.WriteLine("Fin del combate.");
        }

        private static void RealizarTurno(Personaje atacante, Personaje defensor)
        {
            Console.WriteLine($"Turno de {atacante.DatosPersonaje.Nombre1}");
            Console.WriteLine($"{atacante.DatosPersonaje.Nombre1} ataca a {defensor.DatosPersonaje.Nombre1}");

            int ataque = atacante.CaracteristicasPersonaje.Destreza1 * atacante.CaracteristicasPersonaje.Fuerza1 * atacante.CaracteristicasPersonaje.Nivel1;
            int efectividad = new Random().Next(1, 101);
            int defensa = defensor.CaracteristicasPersonaje.Armadura1 * defensor.CaracteristicasPersonaje.Velocidad1;
            int constanteAjuste = 500;

            int precision = atacante.CaracteristicasPersonaje.Precision1;
            int evasion = defensor.CaracteristicasPersonaje.Evasion;

            double probabilidadAcertar = (precision - evasion) / (double)constanteAjuste;

            int randomValue = new Random().Next(0, 51);  // Genera un número entero entre 0 y 100
            double randomPercentage = randomValue / 100.0;  // Convierte el número entero a decimal (0.0 a 1.0)

            if (probabilidadAcertar > randomPercentage)
            {
                int danoProvocado = (int)((ataque * efectividad - defensa) / (double)constanteAjuste);

                if (danoProvocado <= 0)
                {
                    Console.WriteLine("¡El ataque no causa ningún daño!");
                }
                else
                {
                    defensor.CaracteristicasPersonaje.Salud1 -= danoProvocado;
                    Console.WriteLine($"¡{defensor.DatosPersonaje.Nombre1} recibe {danoProvocado} puntos de daño!");
                }
            }
            else
            {
                Console.WriteLine($"{atacante.DatosPersonaje.Nombre1} ha fallado el ataque.");
            }

            Console.WriteLine($"{defensor.DatosPersonaje.Nombre1} tiene {defensor.CaracteristicasPersonaje.Salud1} puntos de salud restantes.");
            Console.WriteLine();
        }
    }
}
