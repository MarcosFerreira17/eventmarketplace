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
        public IActionResult GerarVenda([FromBody] VendaDTO dados)
        {
            //Gerando venda
            Venda venda = new Venda();
            venda.Evento.Id = dados.EventoId;
            venda.Data = dados.Data;
            venda.QuantidadeIngresso = dados.QuantidadeIngresso;
            venda.ValorDaVenda = dados.ValorDaVenda;
            database.Vendas.Add(venda);
            database.SaveChanges();

            // List<Saida> saidas = new List<Saida>();
            // foreach (var saida in dados.Produtos)
            // {
            //     Saida s = new Saida();
            //     s.Quantidade = saida.Quantidade;
            //     s.ValorDaVenda = saida.Subtotal;
            //     s.Venda = venda;
            //     s.Produto = database.Produtos.First(p => p.Id == saida.Produto);
            //     s.Data = DateTime.Now;
            //     saidas.Add(s);
            // }
            // //SALVA NO BANCO
            // database.AddRange(saidas);
            // database.SaveChanges();
            return Ok(new { msg = "Venda processada com sucesso!!" });
        }
    }
}