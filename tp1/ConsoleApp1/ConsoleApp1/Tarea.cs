using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tarea
    {
        //nuevas (de la ultima clase)
        public int Id { get; set; }        
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }               

              
        //Estas las tenía antes del entityframe
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
