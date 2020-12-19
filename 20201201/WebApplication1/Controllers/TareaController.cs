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
    public class TareaController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        private readonly DataContext ctx;
        public TareaController(DataContext _context)
        {
            ctx = _context;
        }

        [HttpGet]
        public List<Tarea> Get()
        {
            //return ctx.Tareas.ToList();
            return ctx.Tareas.Include(i => i.Responsable).ToList();
        }

        [HttpGet("{id}")]
        public Tarea Get (int id)
        {
            return ctx.Tareas.Where(i => i.Id == id).Single();
        }

        //Este se borraria
        /*[HttpPost]
        public Tarea Post(Tarea valor)
        {            
            if (valor.Id == 0)
            {
                ctx.Tareas.Add(valor);
            }
            else
            {
                ctx.Tareas.Attach(valor);
                ctx.Tareas.Update(valor);
            }
            ctx.SaveChanges();
            return valor;
        }*/

        [HttpPost]
        //public IActionResult Post(Tarea valor)
        public Tarea Post(Tarea valor)
        {
            var local = ctx.Tareas.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
                ctx.Entry(local).State = EntityState.Detached;

            if (valor.Id == 0)
            {
                ctx.Entry(valor).State = EntityState.Added;
            }
            else 
            {
                ctx.Entry(valor).State = EntityState.Modified;
            }
            ctx.SaveChanges();
            return valor;
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Borrar = await ctx.Tareas.FindAsync(id);
            if (Borrar == null)
            {
                return NotFound();
            }

            ctx.Tareas.Remove(Borrar);
            await ctx.SaveChangesAsync();

            return NoContent();
        }




    }
}

