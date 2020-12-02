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
    public class DetalleController : ControllerBase
    {        
        /*public IActionResult Index()
        {
            return View();
        }*/
        private readonly DataContext ctx;
        public DetalleController(DataContext _context)
        {
            ctx = _context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            //return ctx.Detalles.ToList();
            return ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToList();
        }

        [HttpGet("{id}")]
        public Detalle Get(int id)
        {
            return ctx.Detalles.Where(i => i.Id == id).Single();
        }

        /*[HttpPost]
        public Detalle Post(Detalle valor)
        {
            if (valor.Id == 0)
            {
                ctx.Detalles.Add(valor);
            }
            else
            {
                ctx.Detalles.Attach(valor);
                ctx.Detalles.Update(valor);
            }
            ctx.SaveChanges();
            return valor;
        }*/

        [HttpPost]
        public IActionResult Post(Detalle valor)
        {
            var local = ctx.Detalles.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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
            return Ok(valor);
        }

    }
}
