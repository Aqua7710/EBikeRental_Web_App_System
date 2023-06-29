using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBikeRental_Web_App_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [StringLength(255)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        [StringLength(255)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        [StringLength(11, MinimumLength = 6)]
        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = null!;
        [Display(Name = "Email")]
        [StringLength(320, MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Display(Name = "Address")]
        [StringLength(128, MinimumLength = 1)]
        public string Address { get; set; } = null!;
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Display(Name = "Bike Rental Active")]
        public bool? BikeRentalActive { get; set; }
        [Display(Name = "Payment ID")]
        public int PaymentId { get; set; }

        public virtual Payment Payment { get; set; } = null!;

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
