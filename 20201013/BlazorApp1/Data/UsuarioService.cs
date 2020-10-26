using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {

        public Usuario[] GetUsuarios()
        {
            Usuario[] resultado = new Usuario[10];
            resultado[0] = new Usuario(1, "storrico", "slo2014");
            resultado[1] = new Usuario(2, "mbielsa", "leeds2020");
            resultado[2] = new Usuario(3, "magoya", "amongus123");
            resultado[3] = new Usuario(4, "tito10", "argentina2020");
            resultado[4] = new Usuario(5, "grivia", "w3wh");
            resultado[5] = new Usuario(6, "gkazka", "netd");
            resultado[6] = new Usuario(7, "mpeluffo", "sarasa2020");
            resultado[7] = new Usuario(8, "jprandi", "lanena999");
            resultado[8] = new Usuario(9, "elemperador", "caniggialibre69");
            resultado[9] = new Usuario(10, "sdelmoro", "ecdm2020");

            return resultado;
        }

        public List<Usuario> ListarUsuario()
        {            
            {
                var ctx = new TareasDbContext();
                var lista = ctx.Usuarios.ToList();
                /*foreach (var item in lista)
                {
                    Console.WriteLine($"Nombre: {item.Nombre} ({item.UsuarioPK})");
                }*/
                return lista;
            }     
        }

        public Usuario SeleccionarUsuario(int id)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            /*if (usuario is null)
            {
                Console.WriteLine("No existe el usuario");
            }
            else
            {
                Console.WriteLine($"Nombre: {usuario.Nombre} ({usuario.UsuarioPK})");
            }*/
            return usuario;
        }

        public Usuario CrearUsuario(string name, string pass)
        {
            var ctx = new TareasDbContext();
            var usuario = new Usuario
            {
                Nombre = name,
                Clave = pass
            };
            ctx.Set<Usuario>().Add(usuario);
            ctx.SaveChanges();
            return usuario;
        }

        public Usuario ActualizarUsuario(int id, string name, string pass = null)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            /*if (usuario is null)
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
            ctx.SaveChanges();*/
            return usuario;
        }

        public Usuario ResetearContraseña(int id, string pass = null)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            /*if (usuario is null)
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
            ctx.SaveChanges();*/
            return usuario;
        }

        static void BorrarUsuario(int id)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).Single();
            ctx.Usuarios.Remove(usuario);
            ctx.SaveChanges();
        }


    }
}