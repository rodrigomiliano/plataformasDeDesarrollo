using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Detalle
    {
        public DateTime  Fecha { get; set; }
        public int Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }
    }
}
