namespace EBikeRental_Web_App_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public DateTime Dob { get; set; }

        public bool? BikeRentalActive { get; set; }

        public int PaymentId { get; set; }

        public virtual Payment Payment { get; set; } = null!;

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
