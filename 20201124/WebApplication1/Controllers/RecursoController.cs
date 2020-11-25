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

        public List<Recurso> Get()
        {
            //return ctx.Recursos.ToList();
            return ctx.Recursos.Include(i => i.Usuario).ToList();
        }
    }
}
