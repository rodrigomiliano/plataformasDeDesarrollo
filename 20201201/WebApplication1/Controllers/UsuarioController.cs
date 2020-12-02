using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        private readonly DataContext ctx;
        public UsuarioController(DataContext _context)
        {
            ctx = _context;
        }              

        [HttpGet]
        public List<Usuario> Get()
        {
            return ctx.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return ctx.Usuarios.Where(i => i.UsuarioPK == id).Single();
        }

        /*[HttpPost]
        public IActionResult Post(Usuario valor)
        {
            if (valor.UsuarioPK == 0)
            {
                ctx.Usuarios.Add(valor);
            }
            else
            {
                ctx.Usuarios.Attach(valor);
                ctx.Usuarios.Update(valor);
            }
            ctx.SaveChanges();
            return Ok(valor);
        }*/

        [HttpPost]
        public IActionResult Post(Usuario valor)
        {
            var local = ctx.Usuarios.Local.FirstOrDefault(e => e.UsuarioPK.Equals(valor.UsuarioPK));

            if (local != null)
                ctx.Entry(local).State = EntityState.Detached;

            if (valor.UsuarioPK == 0)
            {
                ctx.Entry(valor).State = EntityState.Added;
            }
            else
            {
                ctx.Entry(valor).State = EntityState.Modified;
            }
            ctx.SaveChanges();
            return Ok(valor);
        }

    }
}
