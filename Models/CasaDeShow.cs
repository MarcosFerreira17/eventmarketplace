namespace EventMarketplace.Models
{
    public class CasaDeShow
    {
        public CasaDeShow() { }
        public CasaDeShow(int Id, string Nome, string Endereco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Endereco = Endereco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public bool Status { get; set; }

    }
}