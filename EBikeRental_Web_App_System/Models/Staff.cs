namespace EBikeRental_Web_App_System.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public int ManagerId { get; set; }

        public string Address { get; set; } = null!;

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
