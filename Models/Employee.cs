namespace barbershop_g221210047.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Availability { get; set; }

        // Foreign Key
        public int SalonId { get; set; }
        public Salon Salon { get; set; } // Navigation Property
    }

}