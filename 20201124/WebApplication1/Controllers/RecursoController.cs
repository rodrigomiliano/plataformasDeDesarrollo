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

        [HttpPost]
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
        }
    }
}
