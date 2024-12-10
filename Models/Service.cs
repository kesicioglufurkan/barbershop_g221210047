namespace barbershop_g221210047.Models
{
    public class Service
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public int Duration { get; set; } // Dakika cinsinden
        public decimal Price { get; set; }
    }

}
