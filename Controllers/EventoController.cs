using System.IO;
using System;
using System.Globalization;
using System.Linq;
using EventMarketplace.Data;
using EventMarketplace.DTO;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventMarketplace.Controllers
{
    public class EventoController : Controller
    {
        private readonly ApplicationDbContext database;
        private string _filePath;
        public EventoController(ApplicationDbContext database, IWebHostEnvironment env)
        {
            _filePath = env.WebRootPath;
            this.database = database;
        }
        public bool ValidaImagem(IFormFile anexo)
        {
            switch (anexo.ContentType)
            {
                case "image/jpeg":
                    return true;
                case "image/bmp":
                    return true;
                case "image/gif":
                    return true;
                case "image/png":
                    return true;
                default:
                    return false;
            }
        }

        public string SalvarArquivo(IFormFile anexo)
        {
            var nome = Guid.NewGuid().ToString() + anexo.FileName;
            var filePath = _filePath + "\\fotos";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            using (var stream = System.IO.File.Create(filePath + "\\" + nome))
            {
                anexo.CopyToAsync(stream);
            }
            return nome;
        }

        [HttpPost]
        public IActionResult Salvar(EventoDTO eventoTemporario, IFormFile anexo)
        {
            if (ModelState.IsValid)
            {
                Evento evento = new Evento();

                if (!ValidaImagem(anexo))
                {
                    return View(evento);
                }

                var nome = SalvarArquivo(anexo);
                eventoTemporario.Imagem = nome;

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
                ViewBag.Path = _filePath;
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
            var eventos = database.Eventos.Include(c => c.CasaDeShow).ToList();
            foreach (var item in eventos)
            {
                if (id == item.Id)
                {
                    database.Remove(item);
                    database.SaveChanges();
                    return RedirectToAction("Eventos", "Admin");
                }
            }
            return RedirectToAction("Eventos", "Admin");
        }
    }
}