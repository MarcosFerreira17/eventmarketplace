using System;

namespace EventMarketplace.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Evento Evento { get; set; }
        public float ValorDaVenda { get; set; }
        public int QuantidadeIngresso { get; set; }
        public bool Status { get; set; }
    }
}