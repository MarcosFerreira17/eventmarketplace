using System;
namespace EventMarketplace.Models
{
    public class Evento
    {
        public Evento() { }
        public Evento(int Id, string Nome, int Capacidade, string Imagem, DateTime Data, double ValorDoTicket, CasaDeShow CasaDeShow, string Genero)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Capacidade = Capacidade;
            this.Imagem = Imagem;
            this.Data = Data;
            this.ValorDoTicket = ValorDoTicket;
            this.CasaDeShow = CasaDeShow;
            this.Genero = Genero;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public string Imagem { get; set; }
        public DateTime Data { get; set; }
        public double ValorDoTicket { get; set; }
        public CasaDeShow CasaDeShow { get; set; }
        public string Genero { get; set; }
        public bool Status { get; set; }

    }
}