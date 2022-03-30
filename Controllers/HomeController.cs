using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventMarketplace.Models;
using EventMarketplace.Data;
using Microsoft.EntityFrameworkCore;

namespace EventMarketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext database;
        public HomeController(ApplicationDbContext database, ILogger<HomeController> logger)
        {
            this.database = database;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaEventos()
        {
            var eventos = database.Eventos.Include(e => e.CasaDeShow).Where(e => e.Status == true).ToList();
            return View(eventos);
        }

        public IActionResult ListaCasaDeShow()
        {
            var casaDeShows = database.CasaDeShows.Where(ca => ca.Status == true).ToList();
            return View(casaDeShows);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
