using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Staff
    {
        [Display(Name = "Staff ID")]
        public int StaffId { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; } = null!;
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(128, MinimumLength = 1)]
        public string Email { get; set; } = null!;
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, MinimumLength = 6)]
        public string Phone { get; set; } = null!;
        [Display(Name = "Address")]
        [StringLength(128, MinimumLength = 3)]
        public string Address { get; set; } = null!;

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
