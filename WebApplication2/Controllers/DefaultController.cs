using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        private  Conexiones _context;
        private Conexiones db = new Conexiones();
        public DefaultController(Conexiones context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var conexiones = _context.Pedidos.Include(p => p.ClienteIdFkNavigation);
            return View(await conexiones.ToListAsync());
        }

        public IActionResult Index()
        {
            return View(db.Empleados.ToList());
        }
    }
}