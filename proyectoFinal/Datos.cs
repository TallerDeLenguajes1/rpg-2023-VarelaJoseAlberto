namespace DatosPersonaje
{
    public class Datos
    {
        public string Tipo1 { get; set; }
        public string Nombre1 { get; set; }
        public string Apodo1 { get; set; }
        public DateTime FechadeNacimiento1 { get; set; }
        public int Edad1 { get; set; }
        public Datos(string tipo1, string nombre1, string apodo1, DateTime fechadeNacimiento1, int edad1)
        {
            Tipo1 = tipo1;
            Nombre1 = nombre1;
            Apodo1 = apodo1;
            FechadeNacimiento1 = fechadeNacimiento1;
            Edad1 = edad1;
        }
    }
}
