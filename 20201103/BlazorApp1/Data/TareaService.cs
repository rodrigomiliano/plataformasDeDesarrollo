﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        private DataContext context;

        public TareaService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Tarea> Get(int id)
        {
            return await context.Tareas.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Tarea>> GetAll()
        {
            return await context.Tareas.ToListAsync();
        }

        public async Task<Tarea> Save(Tarea value)
        {
            if (value.Id == 0)
            {
                await context.Tareas.AddAsync(value);
            }
            else
            {
                context.Tareas.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tareas.Where(i => i.Id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

    }
}