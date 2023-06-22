namespace CaracteristicasPersonaje
{
    public class Caracteristicas
    {
        public int Velocidad1 { get; set; }
        public int Destreza1 { get; set; }
        public int Fuerza1 { get; set; }
        public int Nivel1 { get; set; }
        public int Armadura1 { get; set; }
        public int Salud1 { get; set; }
        public int Defensa1 { get; set; }
        public int Precision1 { get; set; }
        public int Evasion { get; set; }

        public Caracteristicas(int velocidad1, int destreza1, int fuerza1, int nivel1, int armadura1, int salud1, int defensa1, int precision1, int evasion)
        {
            Velocidad1 = velocidad1;
            Destreza1 = destreza1;
            Fuerza1 = fuerza1;
            Nivel1 = nivel1;
            Armadura1 = armadura1;
            Salud1 = salud1;
            Defensa1 = defensa1;
            Precision1 = precision1;
            Evasion = evasion;
        }


    }

}