using System;
using System.ComponentModel.DataAnnotations;

namespace EventMarketplace.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Imagem { get; set; }
        public DateTime Data { get; set; }
        public float ValorDoTicket { get; set; }
        public int Ingresso { get; set; }
        public CasaDeShow CasaDeShow { get; set; }
        public string Genero { get; set; }

    }
}