using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {

        /*public Recurso[] GetRecursos()
        {
            Recurso[] resultado = new Recurso[10];
            resultado[0] = new Recurso(1, "Programador", 1);
            resultado[1] = new Recurso(2, "Analista", 2);
            resultado[2] = new Recurso(3, "Data entry", 3);
            resultado[3] = new Recurso(4, "Diseñador", 4);
            resultado[4] = new Recurso(5, "Operador", 5);
            resultado[5] = new Recurso(6, "Scrum master", 6);
            resultado[6] = new Recurso(7, "Contador", 7);
            resultado[7] = new Recurso(8, "Tester", 8);
            resultado[8] = new Recurso(9, "Operador", 9);
            resultado[9] = new Recurso(10, "Manager", 10);

            return resultado;
        }*/

        public List<Recurso> ListarRecurso()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Recursos.ToList();
            return lista;
        }

        public Recurso SeleccionarRecurso(int id)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).FirstOrDefault();

            /*if (recurso is null)
            {
                Console.WriteLine("El recurso no existe");
            }
            else
            {
                Console.WriteLine($"Nombre: {recurso.Nombre} ({recurso.Id}) Usuario: {recurso.UsuarioId}");
            }*/
            return recurso;
        }

        public Recurso CrearRecurso(string nombre, int usuario)
        {
            var ctx = new TareasDbContext();
            var recurso = new Recurso
            {
                Nombre = nombre,
                UsuarioId = usuario
            };
            ctx.Set<Recurso>().Add(recurso);
            ctx.SaveChanges();
            return recurso;
        }

        public Recurso ActualizarRecurso(int id, string nombre, int usuarioId = -1)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).FirstOrDefault();

            /*if (recurso is null)
            {
                Console.WriteLine("El recurso no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    recurso.Nombre = nombre;
                }
                if (usuarioId > 0)
                {
                    recurso.UsuarioId = usuarioId;
                }
            }
            ctx.SaveChanges();*/
            return recurso;
        }

        public Recurso BorrarRecurso(int id)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).Single();
            ctx.Recursos.Remove(recurso);
            ctx.SaveChanges();
            return recurso;
        }

    }
}