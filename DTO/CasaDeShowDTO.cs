using System.ComponentModel.DataAnnotations;

namespace EventMarketplace.DTO
{
    public class CasaDeShowDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "A casa de show deve conter um nome.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A casa de show deve ter um endereço.")]
        public string Endereco { get; set; }
    }
}