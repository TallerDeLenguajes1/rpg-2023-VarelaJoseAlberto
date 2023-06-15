namespace DatosPersonaje;
public class Datos
{
    private String? Tipo;
    private String? Nombre;
    private String? Apodo;
    private DateTime FechadeNacimiento;
    private int Edad;
    private double Salud;

    public Datos(string? tipo, string? nombre, string? apodo, DateTime fechadeNacimiento, int edad, double salud)
    {
        Tipo1 = tipo;
        Nombre1 = nombre;
        Apodo1 = apodo;
        FechadeNacimiento1 = fechadeNacimiento;
        Edad1 = edad;
        Salud1 = salud;
    }

    public string? Tipo1 { get => Tipo; set => Tipo = value; }
    public string? Nombre1 { get => Nombre; set => Nombre = value; }
    public string? Apodo1 { get => Apodo; set => Apodo = value; }
    public DateTime FechadeNacimiento1 { get => FechadeNacimiento; set => FechadeNacimiento = value; }
    public int Edad1 { get => Edad; set => Edad = value; }
    public double Salud1 { get => Salud; set => Salud = value; }
}