using System.Linq;
using EventMarketplace.Data;
using EventMarketplace.DTO;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventMarketplace.Controllers
{
    public class EventoController : Controller
    {
        private readonly ApplicationDbContext database;
        public EventoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(EventoDTO eventoTemporario)
        {
            if (ModelState.IsValid)
            {
                Evento evento = new Evento();
                evento.Nome = eventoTemporario.Nome;
                evento.Capacidade = eventoTemporario.Capacidade;
                evento.Data = eventoTemporario.Data;
                evento.Genero = eventoTemporario.Genero;
                evento.ValorDoTicket = eventoTemporario.ValorDoTicket;
                evento.Imagem = eventoTemporario.Imagem;
                evento.CasaDeShow = database.CasaDeShows.First(CasaDeShow => CasaDeShow.Id == eventoTemporario.CasaDeShowId);
                evento.Status = true;

                database.Eventos.Add(evento);
                database.SaveChanges();

                return RedirectToAction("Eventos", "Admin");
            }
            else
            {
                ViewBag.CasaDeShow = database.CasaDeShows.ToList();
                return View("../Admin/NovoEvento");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(EventoDTO eventoTemporario)
        {
            if (ModelState.IsValid)
            {
                var evento = database.Eventos.First(e => e.Id == eventoTemporario.Id);
                evento.Nome = eventoTemporario.Nome;
                evento.Capacidade = eventoTemporario.Capacidade;
                evento.Data = eventoTemporario.Data;
                evento.Genero = eventoTemporario.Genero;
                evento.ValorDoTicket = eventoTemporario.ValorDoTicket;
                evento.Imagem = eventoTemporario.Imagem;
                evento.CasaDeShow = database.CasaDeShows.First(CasaDeShow => CasaDeShow.Id == eventoTemporario.Id);
                database.SaveChanges();
                return RedirectToAction("Eventos", "Admin");
            }
            else
            {
                return View("../Admin/EditarEvento");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if (id > 0)
            {
                var evento = database.Eventos.First(e => e.Id == id);
                evento.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Eventos", "Admin");
        }
    }
}