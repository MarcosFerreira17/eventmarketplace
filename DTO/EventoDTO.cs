using System;
using System.ComponentModel.DataAnnotations;
using EventMarketplace.Models;

namespace EventMarketplace.DTO
{
    public class EventoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O evento deve ter um nome.")]
        public string Nome { get; set; }
        //[Required(ErrorMessage = "O evento deve ter uma imagem.")]
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O evento deve ter uma capacidade determinada, seu limite é de 50.000 pessoas")]
        [Range(0, 50000)]
        public int Capacidade { get; set; }
        [Required(ErrorMessage = "Especifique a data do evento.")]
        public string Data { get; set; }
        [Required(ErrorMessage = "O evento deve conter um valor.")]
        public double ValorDoTicket { get; set; }
        [Required(ErrorMessage = "O evento deve conter um valor.")]
        public string ValorDoTicketString { get; set; }
        [Required(ErrorMessage = "O evento deve conter uma casa de show.")]
        public int CasaDeShowId { get; set; }
        [Required(ErrorMessage = "O evento deve conter um genero musical.")]
        [Range(0, 6, ErrorMessage = "Genero inválido.")]
        public string Genero { get; set; }
    }
}