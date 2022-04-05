using System.Net;
using EventMarketplace.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EventMarketplace.DTO;
using Microsoft.AspNetCore.Authorization;

namespace EventMarketplace.Controllers
{
    [Authorize(Policy = "Admin")]
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

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult CasaDeShow()
        {
            var casaDeShows = database.CasaDeShows.ToList();
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
            var eventos = database.Eventos.Include(c => c.CasaDeShow).ToList();
            return View(eventos);
        }

        public IActionResult NovoEvento()
        {
            var casaDeShow = database.CasaDeShows.ToList();
            foreach (var item in casaDeShow)
            {
                if (item.Id > 0)
                {
                    ViewBag.CasaDeShow = database.CasaDeShows.ToList();
                    return View();
                }
            }
            //TempData["Você não pode cadastrar um evento sem antes cadatrar uma Casa de show"].ToString();
            return RedirectToAction("Error", "Admin");
        }

        public IActionResult EditarEvento(int id)
        {
            var evento = database.Eventos.Include(c => c.CasaDeShow).First(e => e.Id == id);

            EventoDTO eventoView = new EventoDTO();
            eventoView.Id = evento.Id;
            eventoView.Nome = evento.Nome;
            eventoView.Data = evento.Data;
            eventoView.Imagem = evento.Imagem;
            eventoView.Ingresso = evento.Ingresso;
            eventoView.ValorDoTicket = evento.ValorDoTicket;
            eventoView.CasaDeShowId = evento.CasaDeShow.Id;
            ViewBag.CasaDeShow = database.CasaDeShows.ToList();
            return View(eventoView);
        }

        public IActionResult Vendas()
        {
            var vendas = database.Vendas.Include(e => e.Evento).ToList();
            return View(vendas);
        }
    }
}
