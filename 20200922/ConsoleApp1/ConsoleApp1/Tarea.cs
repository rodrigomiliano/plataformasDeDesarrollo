using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tarea
    {
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recurso recurso { get; set; }
        public string Estado { get; set; }

        public Tarea(string titulo, string vencimiento, string estimacion, Recurso recurso, string estado)
        {
        }
    }
}
