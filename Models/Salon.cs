namespace barbershop_g221210047.Models
{
    public class Salon
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string WorkingHours { get; set; }
        public string Address { get; set; }

        // Navigation Property
        public ICollection<Employee> Employees { get; set; }
    }

}
