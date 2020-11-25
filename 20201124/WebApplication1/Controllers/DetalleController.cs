using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
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

        public List<Detalle> Get()
        {
            //return ctx.Detalles.ToList();
            return ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToList();
        }
    }
}
