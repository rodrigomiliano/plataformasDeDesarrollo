using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Detalles
    {
        public DateTime fecha { get; set; }
        public int tiempo { get; set; }
        public Recurso recurso { get; set; }
        public Tarea tarea { get; set; }
    }
}
