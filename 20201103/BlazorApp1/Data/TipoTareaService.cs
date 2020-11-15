using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TipoTareaService
    {
        private DataContext context;

        public TipoTareaService(DataContext _context)
        {
            context = _context;
        }

        public async Task<TipoTarea> Get(int id)
        {
            return await context.TipoTareas.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<TipoTarea>> GetAll()
        {
            return await context.TipoTareas.ToListAsync();
        }

        public async Task<TipoTarea> Save(TipoTarea value)
        {
            if (value.Id == 0)
            {
                await context.TipoTareas.AddAsync(value);
            }
            else
            {
                context.TipoTareas.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.TipoTareas.Where(i => i.Id == id).SingleAsync();
            context.TipoTareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

    }
}