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

        [HttpPost]
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
        }
        

    }
}

