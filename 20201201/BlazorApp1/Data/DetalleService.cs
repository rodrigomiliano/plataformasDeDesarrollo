using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace BlazorApp1.Data
{
    public class DetalleService
    {        
        private DataContext ctx;

        public DetalleService(DataContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Detalle>> ListDetail()
        {
            //return await ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> SelectDetail(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetDetalle(id);
            //return await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
        }


        public async Task<List<Detalle>> GetAll()//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GetAllDetalle();
            //return await ctx.Detalles.ToListAsync();
        }

        public async Task<Detalle> SaveDetail(Detalle value)
        {
            /*if (value.Id == 0)
            {
                await ctx.Detalles.AddAsync(value);
            }
            else
            {
                ctx.Detalles.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;*/
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarDetalle(value);
        }

        public async Task<bool> DeleteDetail(int id)
        {
            //Detalle det = await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
            //ctx.Detalles.Remove(det);
            //await ctx.SaveChangesAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            await remoteService.BorrarDetalle(id);
            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await ctx.Recursos.ToListAsync();
        }

        public async Task<Recurso> GuardaRecurso(Recurso valor)//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarRecurso(valor);

        }

        public async Task<List<Tarea>> GetTask()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await ctx.Tareas.ToListAsync();
        }

        public async Task<Tarea> GuardaTarea(Tarea valor)//agregado 24/11
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44321/api/");
            return await remoteService.GuardarTarea(valor);

        }
    }
}