
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }

        //vencimiento, estimacion, responsable, estado

        public DateTime Vencimiento { get; set; }

        public int Estimacion { get; set; }

        public int ResponsableId { get; set; }
        public Recurso Responsable { get; set; }

        public string Estado { get; set; }
    }
}