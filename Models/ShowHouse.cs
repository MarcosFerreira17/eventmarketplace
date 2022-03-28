namespace EventMarketplace.Models
{
    public class ShowHouse
    {
        public ShowHouse() { }
        public ShowHouse(int Id, string Name, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

    }
}