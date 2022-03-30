using System.ComponentModel.DataAnnotations;

namespace EventMarketplace.DTO
{
    public class CasaDeShowDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "A casa de show deve conter um nome.")]
        [StringLength(100, ErrorMessage = "O nome da casa de show deve ter menos de 100 caracteres.")]
        [MinLength(2, ErrorMessage = "Nome do produto muito pequeno, tente um nome maior que 2 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A casa de show deve ter um endereço.")]
        [StringLength(100, ErrorMessage = "O endereço está muito grande, tente abreviar.")]
        [MinLength(10, ErrorMessage = "O endereço muito pequeno, tente ser mais especifico.")]
        public string Endereco { get; set; }
    }
}