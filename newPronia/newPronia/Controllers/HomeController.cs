using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using newPronia.DAL;
using newPronia.Models;
using newPronia.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace newPronia.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task < IActionResult > Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Sliders = await _context.Sliders.ToListAsync()
            };
            return View(homeVm);

        }





    }
}
