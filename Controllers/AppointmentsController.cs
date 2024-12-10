using barbershop_g221210047.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using barbershop_g221210047.Data;

namespace barbershop_g221210047.Controllers
{
  

    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var appointments = _context.Appointments
                .Include(a => a.User)
                .Include(a => a.Service)
                .Include(a => a.Employee)
                .ToList();

            return View(appointments);
        }

        public IActionResult Create()
        {
            ViewData["Users"] = _context.Users.ToList();
            ViewData["Services"] = _context.Services.ToList();
            ViewData["Employees"] = _context.Employees.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }
    }

}
