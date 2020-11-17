using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
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

        public List<Usuario> Get()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
