﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tareas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int RecursoId { get; set; }
        //public Recurso Responsable { get; set; }
        public string Estado { get; set; }

        public Tareas() { }
        public Tareas(string titulo, DateTime vencimiento, int estimacion, string estado)
        {
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;            
            this.Estado = estado;
        }
    }
}
