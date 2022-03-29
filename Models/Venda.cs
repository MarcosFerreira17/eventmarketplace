using System;

namespace EventMarketplace.Models
{
    public class Venda
    {

        public Venda() { }
        public Venda(int Id, DateTime Data, float Total)
        {
            this.Id = Id;
            this.Data = Data;
            this.Total = Total;
        }
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public float Total { get; set; }

    }
}