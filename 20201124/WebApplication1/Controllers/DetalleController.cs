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

        [HttpPost]
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
        }
    }
}
