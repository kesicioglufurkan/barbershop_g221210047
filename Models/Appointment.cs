namespace barbershop_g221210047.Models
{
    public class Appointment
    {
        public int Id { get; set; } // Primary Key

        // Foreign Keys
        public int UserId { get; set; }
        public User User { get; set; } // Navigation Property

        public int ServiceId { get; set; }
        public Service Service { get; set; } // Navigation Property

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } // Navigation Property

        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; } // Saat bilgisi
        public string Status { get; set; } // "Onaylandı", "Beklemede" gibi
    }

}
