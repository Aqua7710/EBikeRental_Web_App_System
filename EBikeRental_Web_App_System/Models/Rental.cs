using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Rental
    {
        [Display(Name = "Rental ID")]
        public int RentalId { get; set; }


        [Display(Name = "Customer ID")]
        public int CustomerId { get; set; }


        [Display(Name = "Bike ID")]
        public int BikeId { get; set; }


        [Display(Name = "Borrow Duration")]
        [Range(maximum: 90, minimum: 1)]
        [Required]
        public double BorrowDuration { get; set; } // borrow duration max: 90 (days), min: 1 (day)


        [Display(Name = "Staff ID")]
        public int StaffId { get; set; }


        [Display(Name = "Collection time")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime CollectionTime { get; set; } // collection time 


        [Display(Name = "Return time")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ReturnTime { get; set; } // return time


        public virtual Bike Bike { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;

        public virtual Staff Staff { get; set; } = null!;
    }
}
