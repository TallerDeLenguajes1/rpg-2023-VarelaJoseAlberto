using DatosPersonaje;
using CaracteristicasPersonaje;
namespace EspacioPersonajes
{
    public class Personaje
    {
        public Datos? datosPersonaje;
        public Caracteristicas? caracteristicasPersonaje;

        public Personaje(Datos datosPersonaje, Caracteristicas caracteristicasPersonaje)
        {
            this.datosPersonaje = datosPersonaje!;
            this.caracteristicasPersonaje = caracteristicasPersonaje!;
        }

        public Datos? DatosPersonaje { get => datosPersonaje; set => datosPersonaje = value; }
        public Caracteristicas? CaracteristicasPersonaje { get => caracteristicasPersonaje; set => caracteristicasPersonaje = value; }



        // public Datos DatosPersonaje1 { get => DatosPersonaje; set => DatosPersonaje = value; }
        // public Caracteristicas CaracteristicasPersonaje1 { get => CaracteristicasPersonaje; set => CaracteristicasPersonaje = value; }
    }
}