using DatosPersonaje;
using CaracteristicasPersonaje;
using System.Text.Json.Serialization;
namespace EspacioPersonajes
{
    public class Personaje
    {
        public Datos DatosPersonaje { get; set; }
        public Caracteristicas CaracteristicasPersonaje { get; set; }

        [JsonConstructor]
        public Personaje(Datos datosPersonaje, Caracteristicas caracteristicasPersonaje)
        {
            DatosPersonaje = datosPersonaje!;
            CaracteristicasPersonaje = caracteristicasPersonaje;
        }



        // public Datos DatosPersonaje1 { get => DatosPersonaje; set => DatosPersonaje = value; }
        // public Caracteristicas CaracteristicasPersonaje1 { get => CaracteristicasPersonaje; set => CaracteristicasPersonaje = value; }
    }
}