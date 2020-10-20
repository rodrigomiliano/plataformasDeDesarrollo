using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Tareas[] GetTareas()
        {

            Tareas[] resultado = new Tareas[10];
            resultado[0] = new Tareas();

            return resultado;
        }
    }
}
