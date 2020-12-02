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
    public class RecursoController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        private readonly DataContext ctx;
        public RecursoController(DataContext _context)
        {
            ctx = _context;
        }

        [HttpGet]
        public List<Recurso> Get()
        {
            //return ctx.Recursos.ToList();
            return ctx.Recursos.Include(i => i.Usuario).ToList();
        }

        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return ctx.Recursos.Where(i => i.Id == id).Single();
        }

        /*[HttpPost]
        public Recurso Post(Recurso valor)
        {
            if (valor.Id == 0)
            {
                ctx.Recursos.Add(valor);
            }
            else
            {
                ctx.Recursos.Attach(valor);
                ctx.Recursos.Update(valor);
            }
            ctx.SaveChanges();
            return valor;
        }*/

        [HttpPost]
        public IActionResult Post(Recurso valor)
        {
            var local = ctx.Recursos.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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
