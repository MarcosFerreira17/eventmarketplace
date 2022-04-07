using System.Net;
using System.Reflection.Metadata;
using System;
using System.Linq;
using EventMarketplace.Data;
using EventMarketplace.DTO;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace eventmarketplace.Controllers
{
    public class VendaController : Controller
    {
        private readonly ApplicationDbContext database;
        public VendaController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult GerarVenda([FromBody] VendaDTO dados)
        {


            Venda venda = new Venda();

            venda.Data = DateTime.Now;
            venda.ValorDaVenda = dados.valorDaVenda;
            venda.QuantidadeIngresso = dados.quantidadeIngresso;
            venda.Evento = database.Eventos.First(evento => evento.Id == dados.evento);
            venda.Status = true;
            database.Vendas.Add(venda);
            database.SaveChanges();

            return Ok();
        }

        public class VendaDTO
        {
            public int evento;
            public int quantidadeIngresso;
            public float valorDaVenda;
        }
    }
}