using System.ComponentModel.DataAnnotations;

namespace EventMarketplace.DTO
{
    public class ShowHouseDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "A casa de show deve conter um nome.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A casa de show deve ter um endereço.")]
        public string Address { get; set; }
    }
}