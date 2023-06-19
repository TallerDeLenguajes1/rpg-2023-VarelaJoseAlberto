namespace CaracteristicasPersonaje
{
    public class Caracteristicas
    {
        private int Velocidad;// 1 a 10
        private int Destreza; //1 a 5
        private int Fuerza;//1 a 10
        private int Nivel; //1 a 10
        private int Armadura; //1 a 10
        private int Salud; // 100

        public Caracteristicas(int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
        {
            Velocidad1 = velocidad;
            Destreza1 = destreza;
            Fuerza1 = fuerza;
            Nivel1 = nivel;
            Armadura1 = armadura;
            Salud1 = salud;
        }

        public int Velocidad1 { get => Velocidad; set => Velocidad = value; }
        public int Destreza1 { get => Destreza; set => Destreza = value; }
        public int Fuerza1 { get => Fuerza; set => Fuerza = value; }
        public int Nivel1 { get => Nivel; set => Nivel = value; }
        public int Armadura1 { get => Armadura; set => Armadura = value; }
        public int Salud1 { get => Salud; set => Salud = value; }
    }
}