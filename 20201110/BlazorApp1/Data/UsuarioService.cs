﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // Metodos de Usuarios (User)
        public async Task<List<Usuario>> ListUser()
        {
            return await ctx.Usuarios.ToListAsync();
        }

        public async Task<Usuario> SelectUser(int id)
        {
            return await ctx.Usuarios.Where(i => i.UsuarioPK == id).SingleAsync();
        }

        public async Task<Usuario> SaveUser(Usuario value)
        {
            if (value.UsuarioPK == 0)
            {
                await ctx.Usuarios.AddAsync(value);
            }
            else
            {
                ctx.Usuarios.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;
        }

        public async Task<bool> DeleteUser(int id)
        {
            Usuario user = await ctx.Usuarios.Where(i => i.UsuarioPK == id).SingleAsync();

            ctx.Usuarios.Remove(user);

            await ctx.SaveChangesAsync();
            return true;
        }
    }
}