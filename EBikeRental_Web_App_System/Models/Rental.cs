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
        public double BorrowDuration { get; set; }
        [Display(Name = "Staff ID")]
        public int StaffId { get; set; }
        [Display(Name = "Collection time")]
        public DateTime CollectionTime { get; set; }
        [Display(Name = "Return time")]
        public DateTime ReturnTime { get; set; }
        public virtual Bike Bike { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;

        public virtual Staff Staff { get; set; } = null!;
    }
}
