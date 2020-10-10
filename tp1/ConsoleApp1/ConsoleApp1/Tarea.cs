using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tarea
    {
        public string titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public string estimacion { get; set; }
        public Recurso responsable { get; set; }
        public string Estado { get; set; }

        public Tarea(string titulo, DateTime vencimiento, string estimacion, Recurso responsable, string estado)
        {
        }
    }
}
