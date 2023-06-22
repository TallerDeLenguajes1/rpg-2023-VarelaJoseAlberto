using System.Text.Json;
using EspacioPersonajes;

namespace EspacioPersonajesJson
{
    public class PersonajesJson
    {
        public static void GuardarPersonajes(List<Personaje> personajes, string nombreArchivo)
        {
            string json = JsonSerializer.Serialize(personajes);
            File.WriteAllText(nombreArchivo, json);
        }

        public static List<Personaje> LeerPersonajes(string nombreArchivo)
        {
            if (Existe(nombreArchivo))
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo);
                string json = File.ReadAllText(nombreArchivo);

                return JsonSerializer.Deserialize<List<Personaje>>(json)!;
            }
            else
            {
                return new List<Personaje>();
            }
        }

        public static bool Existe(string nombreArchivo)
        {
            return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
        }
    }
}
