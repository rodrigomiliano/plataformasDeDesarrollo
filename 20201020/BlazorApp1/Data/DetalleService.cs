using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {
        // Metodos de Detalle (Detail)

        public List<Detalle> ListarDetalle()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Detalles.ToList();
            return lista;
        }

        public Detalle SeleccionarDetalle(int id)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            /*if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                Console.WriteLine($"Fecha: {detalle.Fecha} ({detalle.Id}) Tiempo: {detalle.Tiempo} " +
                                    $"Recurso: {detalle.RecursoId} Tarea: {detalle.TareaId}");
            }*/
            return detalle;
        }

        public Detalle CrearDetalle(int tiempo, int recurso, int tarea)
        {
            var ctx = new TareasDbContext();
            var detalle = new Detalle
            {
                Fecha = DateTime.Now,
                Tiempo = tiempo,
                RecursoId = recurso,
                TareaId = tarea
            };
            ctx.Set<Detalle>().Add(detalle);
            ctx.SaveChanges();
            return detalle;
        }

        public Detalle ActualizarDetalle(int id, int tiempo, int recId, int tareaId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            /*if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (tiempo > 0)
                {
                    detalle.Tiempo = tiempo;
                }
                if (recId > 0)
                {
                    detalle.RecursoId = recId;
                }
                if (tareaId > 0)
                {
                    detalle.TareaId = tareaId;
                }
            }
            ctx.SaveChanges();*/
            return detalle;
        }

        public Detalle ActualizarTiempo(int id, int tiempo)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            /*if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (tiempo > 0)
                {
                    detalle.Tiempo = tiempo;
                }
            }
            ctx.SaveChanges();*/
            return detalle;
        }

       public Detalle ActualizarRecursoId(int id, int recId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            /*if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (recId > 0)
                {
                    detalle.RecursoId = recId;
                }
            }
            ctx.SaveChanges();*/
            return detalle;
        }

        public Detalle ActualizarTareaId(int id, int tareaId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            /*if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (tareaId > 0)
                {
                    detalle.TareaId = tareaId;
                }
            }
            ctx.SaveChanges();*/
            return detalle;
        }

        public Detalle BorrarDetalle(int id)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).Single();
            ctx.Detalles.Remove(detalle);
            ctx.SaveChanges();
            return detalle;
        }
    }
}