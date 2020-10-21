using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        public Tarea[] GetTareas()
        {
            Tarea[] resultado = new Tarea[10];
            resultado[0] = new Tarea(1, "Cableado", "2020/09/27", 15, 1, "Realizada");
            resultado[1] = new Tarea(2, "Electricidad", "2020/09/28", 20, 2, "Realizada");
            resultado[2] = new Tarea(3, "Discusion", "2020/09/29", 10, 3, "Pendiente");
            resultado[3] = new Tarea(4, "Basurero", "2020/09/30", 13, 4, "Incompleta");
            resultado[4] = new Tarea(5, "Busqueda", "2020/10/01", 16, 5, "Realizada");
            resultado[5] = new Tarea(6, "Alineación", "2020/10/02", 27, 6, "Realizada");
            resultado[6] = new Tarea(7, "Escanear", "2020/10/03", 32, 7, "Realizada");
            resultado[7] = new Tarea(8, "Diagnostico", "2020/10/04", 99, 8, "Incompleta");
            resultado[8] = new Tarea(9, "Limpieza", "2020/10/05", 41, 9, "Pendiente");
            resultado[9] = new Tarea(10, "Monitoreo", "2020/10/06", 22, 10, "Pendiente");

            return resultado;
        }
        


    }
}
