using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private DataContext ctx;

        public UsuarioService(DataContext _context)
        {
            ctx = _context;
        }
                
        public async Task<List<Usuario>> ListUser()
        {
            //return await ctx.Usuarios.ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> SelectUser(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            //return await ctx.Usuarios.Where(i => i.UsuarioPK == id).SingleAsync();
            return await remoteService.GetUsuario(id);
        }

               
        public async Task<List<Usuario>> GetAll()//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllUsuario();
            //return await ctx.Usuarios.ToListAsync();
        }


        public async Task<Usuario> SaveUser(Usuario value)
        {
            /*if (value.UsuarioPK == 0)
            {
                await ctx.Usuarios.AddAsync(value);
            }
            else
            {
                ctx.Usuarios.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;*/
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarUsuario(value);

        } 

        public async Task<bool> DeleteUser(int id)
        {
            //Usuario user = await ctx.Usuarios.Where(i => i.UsuarioPK == id).SingleAsync();
            //ctx.Usuarios.Remove(user);
            //await ctx.SaveChangesAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            await remoteService.BorrarUsuario(id);
            return true;
        }

        /*public async Task<List<Tarea>> GetTareas()//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllTarea();

        }

        public async Task<Tarea> GuardaTarea(Tarea valor)//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarTarea(valor);

        }
        */
    }
}