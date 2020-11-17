using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Data
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

        public List<Tarea> Get()
        {
            return ctx.Tareas.ToList();
        }
    }
}

