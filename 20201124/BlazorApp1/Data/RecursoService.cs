using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;
using System.Net;

namespace BlazorApp1.Data
{
    public class RecursoService
    {      
        private DataContext ctx;

        public RecursoService(DataContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Recurso>> ListResource()
        {
            //return await ctx.Recursos.Include(i => i.Usuario).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> SelectResource(int id)
        {
            return await ctx.Recursos.Where(i => i.Id == id).SingleAsync();
        }


        public async Task<List<Recurso>> GetAll()//agregado 24/11
        {
            return await ctx.Recursos.ToListAsync();
        }

        public async Task<Recurso> SaveResource(Recurso value)
        {
            /*if (value.Id == 0)
            {
                await ctx.Recursos.AddAsync(value);
            }
            else
            {
                ctx.Recursos.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;*/
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarRecurso(value);
        }

        public async Task<bool> DeleteResource(int id)
        {
            Recurso res = await ctx.Recursos.Where(i => i.Id == id).SingleAsync();

            ctx.Recursos.Remove(res);

            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usuario>> GetUser()
        {
            //return await ctx.Usuarios.ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> GuardaUsuario(Usuario valor)//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarUsuario(valor);

        }

    }
}