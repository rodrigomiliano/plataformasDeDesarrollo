using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u1 = new Usuario("storrico", "slo2014");
            Usuario u2 = new Usuario("mbielsa", "leeds2020");
            Usuario u3 = new Usuario("mlegrand", "almorzando20");
            Usuario u4 = new Usuario("magoya", "amongus123");
            Usuario u5 = new Usuario("grivia", "w3wh");
            Recurso r1 = new Recurso("Sebastian", u1);
            Recurso r2 = new Recurso("Marcelo", u2);
            Recurso r3 = new Recurso("Mirta", u3);
            Recurso r4 = new Recurso("Mariano", u4);
            Recurso r5 = new Recurso("Geralt", u5);

            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Cableado", new DateTime(2020,9,27), "12", r1, "Realizada"));
            tareas.Add(new Tarea("Electricidad", new DateTime(2020, 9, 28), "13", r2, "Realizada"));
            tareas.Add(new Tarea("Discusion", new DateTime(2020, 9, 29), "14", r3, "Incompleta"));
            tareas.Add(new Tarea("Basurero", new DateTime(2020, 9, 30), "15", r4, "Pendiente"));
            tareas.Add(new Tarea("Busqueda", new DateTime(2020, 9, 28), "16", r5, "Incompleta"));

            Console.WriteLine();
        }
    }
}