using System;
using System.ComponentModel.DataAnnotations;
using EventMarketplace.Models;

namespace EventMarketplace.DTO
{
    public class VendaDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Especifique a data do evento.")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        [Required]
        public int EventoId { get; set; }
        [Required]
        public float ValorDaVenda { get; set; }
        [Required(ErrorMessage = "A venda deve ter uma quantidade minima de ingressos.")]
        [Range(1, 10, ErrorMessage = "Você pode comprar até 10 ingressos.")]
        public float QuantidadeIngresso { get; set; }
    }
}