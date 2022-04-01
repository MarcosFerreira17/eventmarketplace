using System;
using System.Globalization;
using System.Linq;
using EventMarketplace.Data;
using EventMarketplace.DTO;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                evento.Imagem = eventoTemporario.Imagem;
                evento.Data = eventoTemporario.Data;
                evento.Genero = eventoTemporario.Genero;
                evento.ValorDoTicket = float.Parse(eventoTemporario.ValorDoTicketString, CultureInfo.InvariantCulture.NumberFormat);
                evento.Ingresso = eventoTemporario.Ingresso;
                evento.CasaDeShow = database.CasaDeShows.First(CasaDeShow => CasaDeShow.Id == eventoTemporario.CasaDeShowId);
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
                var evento = database.Eventos.Include(c => c.CasaDeShow).First(e => e.Id == eventoTemporario.Id);
                evento.Nome = eventoTemporario.Nome;
                evento.Imagem = eventoTemporario.Imagem;
                evento.Data = eventoTemporario.Data;
                evento.Genero = eventoTemporario.Genero;
                evento.ValorDoTicket = float.Parse(eventoTemporario.ValorDoTicketString, CultureInfo.InvariantCulture.NumberFormat);
                evento.Ingresso = eventoTemporario.Ingresso;
                evento.CasaDeShow.Id = eventoTemporario.CasaDeShowId;
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
                database.Eventos.Remove(evento);
                database.SaveChanges();
                return RedirectToAction("Eventos", "Admin");
            }
            return RedirectToAction("Eventos", "Admin");

        }
    }
}