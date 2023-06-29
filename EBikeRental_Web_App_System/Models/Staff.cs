using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Staff
    {
        [Display(Name = "Staff ID")]
        public int StaffId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        [Display(Name = "Phone")]
        public string Phone { get; set; } = null!;
        [Display(Name = "Manager ID")]
        public int ManagerId { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; } = null!;

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
