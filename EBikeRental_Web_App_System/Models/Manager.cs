namespace EBikeRental_Web_App_System.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Address { get; set; } = null!;
    }
}
