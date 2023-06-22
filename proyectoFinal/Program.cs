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
            if (!string.IsNullOrEmpty(opcion))
            {
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
}
