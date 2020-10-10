using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Recurso recurso1 = new Recurso();

            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Ejercicio1", "2020-9-22", "10", recurso1, "Realizada"));
            //tareas.Add(new Tarea("Ejercicio2", "2020-9-23", "12", "Fabio", "Realizada"));
            //tareas.Add(new Tarea("Ejercicio3", "2020-9-24", "12", "Lorena", "Realizada"));
            //tareas.Add(new Tarea("Ejercicio4", "2020-9-25", "11", "Juliana", "Pendiente"));
            //tareas.Add(new Tarea());

            Console.WriteLine()
        }
    }
}