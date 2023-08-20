using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBikeRental_Web_App_System.Models
{
    public class Customer
    {
        [Display(Name = "Customer ID")]
        public int CustomerId { get; set; } // customer id


        [StringLength(maximumLength: 128, MinimumLength = 1)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;  // first name max: 128, min: 1


        [StringLength(maximumLength: 128, MinimumLength = 1)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!; // last name max: 128, min: 1


        [StringLength(maximumLength: 11, MinimumLength = 6)]
        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]+$")]
        public string Phone { get; set; } = null!; // phone number max: 11, min: 6


        [Display(Name = "Email")]
        [StringLength(maximumLength: 320, MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!; // email max: 320, min: 3


        [Display(Name = "Address")]
        [StringLength(128, MinimumLength = 3)] 
        public string Address { get; set; } = null!; // address  max: 128, min: 1


        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; } // dob


        [Display(Name = "Bike Rental Active")]
        public bool BikeRentalActive { get; set; } // bike rental active


        
        public int PaymentId { get; set; }


        public string FullName // used in rental table to display customers full name 
        {
            get { return FirstName + " " + LastName; }
        }
        [Display(Name = "Payment ID")]
        public virtual Payment Payment { get; set; } = null!;


        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
