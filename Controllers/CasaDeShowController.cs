using System;
using System.Linq;
using EventMarketplace.Data;
using EventMarketplace.DTO;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventMarketplace.Controllers
{
    public class CasaDeShowController : Controller
    {
        private readonly ApplicationDbContext database;
        public CasaDeShowController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CasaDeShowDTO casaDeShowTemporaria)
        {
            if (ModelState.IsValid)
            {
                CasaDeShow casaDeShow = new CasaDeShow();
                casaDeShow.Nome = casaDeShowTemporaria.Nome;
                casaDeShow.Endereco = casaDeShowTemporaria.Endereco;

                database.CasaDeShows.Add(casaDeShow);
                database.SaveChanges();
                return RedirectToAction("CasaDeShow", "Admin");
            }
            else
            {
                return View("../Admin/NovaCasaDeShow");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(CasaDeShowDTO casaDeShowTemporaria)
        {
            if (ModelState.IsValid)
            {
                var casaDeShow = database.CasaDeShows.First(ca => ca.Id == casaDeShowTemporaria.Id);
                casaDeShow.Nome = casaDeShowTemporaria.Nome;
                casaDeShow.Endereco = casaDeShowTemporaria.Endereco;
                database.SaveChanges();
                return RedirectToAction("CasaDeShow", "Admin");
            }
            else
            {
                return View("../Admin/EditarCasaDeShow");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {

            var eventos = database.Eventos.Include(c => c.CasaDeShow).ToList();
            var casaDeShow = database.CasaDeShows.First(ca => ca.Id == id);
            foreach (var item in eventos)
            {
                if (item.CasaDeShow.Id == casaDeShow.Id)
                {
                    return RedirectToAction("Eventos", "Admin");
                }
            }
            database.Remove(casaDeShow);
            database.SaveChanges();
            return RedirectToAction("CasaDeShow", "Admin");
        }

    }
}