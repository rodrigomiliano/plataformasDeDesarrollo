using ConsoleApp1;
using System;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // ------------------------ Usando Metodos crear -----------------------------------------------------
            CrearUsuario("storrico", "slo2014");
            CrearUsuario("mbielsa", "leeds2020");
            CrearUsuario("magoya", "amongus123");
            CrearUsuario("tito10", "argentina2020");
            CrearUsuario("grivia", "w3wh");

            CrearRecurso("Programador", 1);
            CrearRecurso("Analista", 2);
            CrearRecurso("Data entry", 3);
            CrearRecurso("Diseñador", 4);
            CrearRecurso("Operador", 5);


            CrearTareas("Cableado", "2020/09/27", 15, 1, "realizada");
            CrearTareas("Electricidad", "2020/09/28", 20, 2, "realizada");
            CrearTareas("Discusion", "2020/09/29", 10, 3, "pendiente");
            CrearTareas("Basurero", "2020/09/30", 13, 4, "incompleta");
            CrearTareas("Busqueda", "2020/10/01", 16, 5, "realizada");


            CrearDetalle(14, 1, 1);
            CrearDetalle(21, 2, 2);
            CrearDetalle(11, 3, 3);
            CrearDetalle(12, 4, 4);
            CrearDetalle(15, 5, 5);

        }

        // ------------------------ Metodos de Usuario ---------------------------------------------------
        static void ListarUsuario()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.UsuarioPK})");
            }

        }

        private static void SeleccionarUsuario(int id)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            if (usuario is null)
            {
                Console.WriteLine("No existe el usuario");
            }
            else
            {
                Console.WriteLine($"Nombre: {usuario.Nombre} ({usuario.UsuarioPK})");
            }
        }

        static void CrearUsuario(string name, string pass)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                Nombre = name,
                Clave = pass
            });

            ctx.SaveChanges();
        }

        static void ActualizarUsuario(int id, string name, string pass = null)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            if (usuario is null)
            {
                Console.WriteLine("El usuario no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(name))
                {
                    usuario.Nombre = name;
                }
                if (!string.IsNullOrEmpty(pass))
                {
                    usuario.Clave = pass;
                }
            }
            ctx.SaveChanges();
        }

        static void ResetearContraseña(int id, string pass = null)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            if (usuario is null)
            {
                Console.WriteLine("El usuario no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(pass))
                {
                    usuario.Clave = pass;
                }
            }
            ctx.SaveChanges();
        }

        static void BorrarUsuario(int id)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).Single();
            ctx.Usuarios.Remove(usuario);
            ctx.SaveChanges();
        }

        // ------------------------ Metodos de Tareas ---------------------------------------------------
        static void ListadoTareas()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Tareas.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Titulo: {item.Titulo} ({item.Id}) Vencimiento: {item.Vencimiento} " +
                    $"Estimacion: {item.Estimacion} Responsable: {item.RecursoId} Estado: {item.Estado}");
            }
        }

        static void SeleccionarTareas(int id)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                Console.WriteLine($"Titulo: {tarea.Titulo} ({tarea.Id}) Vencimiento: {tarea.Vencimiento} Estimacion: {tarea.Estimacion} " +
                                $"Responsable: {tarea.RecursoId} Estado {tarea.Estado}");
            }
        }

        static void CrearTareas(string titulo, string vencimiento, int estimacion, int responsable, string estado = null)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Tarea>().Add(new Tarea
            {
                Titulo = titulo,
                Vencimiento = DateTime.Parse(vencimiento),
                Estimacion = estimacion,
                RecursoId = responsable,
                Estado = estado
            });

            ctx.SaveChanges();
        }

        static void ActualizarNombreTareas(int id, string tit)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.Titulo = tit;
            }
            ctx.SaveChanges();
        }

        static void ActualizarEstadoTareas(int id, string sta)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.Estado = sta;
            }
            ctx.SaveChanges();
        }

        static void ActualizarRecursoTarea(int id, int resp)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.RecursoId = resp;
            }
            ctx.SaveChanges();
        }

        static void ActualizarTiempoTarea(int id, string venc, int est = -1)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.Vencimiento = DateTime.Parse(venc);

                if (est > 0)
                {
                    tarea.Estimacion = est;
                }
            }
            ctx.SaveChanges();
        }

        static void BorrarTarea(int id)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).Single();
            ctx.Tareas.Remove(tarea);
            ctx.SaveChanges();
        }

        // ------------------------ Metodos de Recurso ---------------------------------------------------

        static void ListarRecurso()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Recursos.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.Id}) Usuario: {item.UsuarioId}");
            }
        }

        static void SelleccionarRecurso(int id)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).FirstOrDefault();

            if (recurso is null)
            {
                Console.WriteLine("El recurso no existe");
            }
            else
            {
                Console.WriteLine($"Nombre: {recurso.Nombre} ({recurso.Id}) Usuario: {recurso.UsuarioId}");
            }
        }

        static void CrearRecurso(string nombre, int usuario)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Recurso>().Add(new Recurso
            {
                Nombre = nombre,
                UsuarioId = usuario
            });

            ctx.SaveChanges();
        }

        static void ActualizarRecurso(int id, string name, int user = -1)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).FirstOrDefault();

            if (recurso is null)
            {
                Console.WriteLine("El recurso no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(name))
                {
                    recurso.Nombre = name;
                }
                if (user > 0)
                {
                    recurso.UsuarioId = user;
                }
            }
            ctx.SaveChanges();
        }

        static void BorrarRecurso(int id)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).Single();
            ctx.Recursos.Remove(recurso);
            ctx.SaveChanges();
        }

        // ------------------------ Metodos de Detalle ---------------------------------------------------

        static void ListarDetalle()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Detalles.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Fecha: {item.Fecha} ({item.Id}) Tiempo: {item.Tiempo} " +
                                    $"Recurso: {item.RecursoId} Tarea: {item.TareaId}");
            }
        }

        static void SeleccionarDetalle(int id)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                Console.WriteLine($"Fecha: {detalle.Fecha} ({detalle.Id}) Tiempo: {detalle.Tiempo} " +
                                    $"Recurso: {detalle.RecursoId} Tarea: {detalle.TareaId}");
            }
        }

        static void CrearDetalle(int time, int recurso, int tarea)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Detalle>().Add(new Detalle
            {
                Fecha = DateTime.Now,
                Tiempo = time,
                RecursoId = recurso,
                TareaId = tarea
            });

            ctx.SaveChanges();
        }

        static void ActualizarDetalle(int id, int time, int recId, int taskId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (time > 0)
                {
                    detalle.Tiempo = time;
                }
                if (recId > 0)
                {
                    detalle.RecursoId = recId;
                }
                if (taskId > 0)
                {
                    detalle.TareaId = taskId;
                }
            }
            ctx.SaveChanges();
        }

        static void ActualizarTiempoDetalle(int id, int time)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (time > 0)
                {
                    detalle.Tiempo = time;
                }
            }
            ctx.SaveChanges();
        }

        static void ActualizarRecursoDetalle(int id, int recId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
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
            ctx.SaveChanges();
        }

        static void ActualizarTareaDetalle(int id, int taskId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (taskId > 0)
                {
                    detalle.TareaId = taskId;
                }
            }
            ctx.SaveChanges();
        }

        static void BorrarDetalle(int id)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).Single();
            ctx.Detalles.Remove(detalle);
            ctx.SaveChanges();
        }
    }
}