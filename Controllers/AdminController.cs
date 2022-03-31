using System;
using EventMarketplace.Data;
using Microsoft.AspNetCore.Mvc;
using EventMarketplace.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EventMarketplace.DTO;

namespace EventMarketplace.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext database;
        public AdminController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CasaDeShow()
        {
            var casaDeShows = database.CasaDeShows.Where(ca => ca.Status == true).ToList();
            return View(casaDeShows);
        }

        public IActionResult NovaCasaDeShow()
        {
            return View();
        }

        public IActionResult EditarCasaDeShow(int id)
        {
            var casaDeShow = database.CasaDeShows.First(ca => ca.Id == id);
            CasaDeShowDTO casaDeShowView = new CasaDeShowDTO();
            casaDeShowView.Id = casaDeShow.Id;
            casaDeShowView.Nome = casaDeShow.Nome;
            casaDeShowView.Endereco = casaDeShow.Endereco;
            return View(casaDeShowView);
        }

        public IActionResult Eventos()
        {
            var eventos = database.Eventos.Include(e => e.CasaDeShow).Where(e => e.Status == true).ToList();
            return View(eventos);
        }

        public IActionResult NovoEvento()
        {
            ViewBag.CasaDeShow = database.CasaDeShows.ToList();
            return View();
        }

        public IActionResult EditarEvento(int id)
        {
            var evento = database.Eventos.Include(e => e.CasaDeShow).First(e => e.Id == id);

            EventoDTO eventoView = new EventoDTO();

            eventoView.Id = evento.Id;
            eventoView.Nome = evento.Nome;
            eventoView.Capacidade = evento.Capacidade;
            eventoView.Data = evento.Data;
            eventoView.Imagem = evento.Imagem;
            eventoView.ValorDoTicket = evento.ValorDoTicket;
            eventoView.CasaDeShowId = evento.CasaDeShow.Id;

            ViewBag.CasaDeShow = database.CasaDeShows.ToList();

            return View(eventoView);
        }


    }
}
