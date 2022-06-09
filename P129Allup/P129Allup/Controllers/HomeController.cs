using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P129Allup.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Products.ToListAsync());
        }
    }
}
