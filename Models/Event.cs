using System;
namespace EventMarketplace.Models
{
    public class Event
    {
        public Event() { }
        public Event(int Id, string Name, int Capacity, string Imagem, DateTime Date, double TicketValue, ShowHouse ShowHouse, string Genre)
        {
            this.Id = Id;
            this.Name = Name;
            this.Capacity = Capacity;
            this.Imagem = Imagem;
            this.Date = Date;
            this.TicketValue = TicketValue;
            this.ShowHouse = ShowHouse;
            this.Genre = Genre;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Imagem { get; set; }
        public DateTime Date { get; set; }
        public double TicketValue { get; set; }
        public ShowHouse ShowHouse { get; set; }
        public string Genre { get; set; }
        public bool Status { get; set; }

    }
}