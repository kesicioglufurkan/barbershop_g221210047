
using barbershop_g221210047.Models;
using Microsoft.AspNetCore.Mvc;
using barbershop_g221210047.Data;

namespace barbershop_g221210047.Controllers
{

    public class SalonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var salons = _context.Salons.ToList();
            return View(salons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Salon salon)
        {
            if (ModelState.IsValid)
            {
                _context.Salons.Add(salon);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(salon);
        }
    }

}
