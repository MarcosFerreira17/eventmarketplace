using System;
using System.Linq;
using EventMarketplace.Data;
using EventMarketplace.DTO;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult GerarVenda([FromBody] SaidaDTO dados)
        {
            return Ok(new { msg = "Compra  processada com sucesso!!" });
        }

        public class SaidaDTO
        {
            public int evento;
            public int quantidadeIngresso;
            public float totalVenda;
        }
    }
}