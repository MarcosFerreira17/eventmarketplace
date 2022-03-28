using System;
using System.ComponentModel.DataAnnotations;
using EventMarketplace.Models;

namespace EventMarketplace.DTO
{
    public class EventDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O evento deve ter um nome.")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "O evento deve ter uma imagem.")]
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O evento deve ter uma capacidade determinada, seu limite é de 50.000 pessoas")]
        [Range(0, 50000)]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "Especifique a data do evento.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "O evento deve conter um valor.")]
        public double TicketValue { get; set; }
        [Required(ErrorMessage = "O evento deve conter uma casa de show.")]
        public ShowHouse ShowHouseId { get; set; }
        [Required(ErrorMessage = "O evento deve conter um genero musical.")]
        public string Genre { get; set; }
    }
}