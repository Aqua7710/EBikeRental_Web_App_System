using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        public int CustomerId { get; set; }

        public int BikeId { get; set; }

        public double BorrowDuration { get; set; }

        public int StaffId { get; set; }

        public DateTime CollectionTime { get; set; }

        public DateTime ReturnTime { get; set; }

        public virtual Bike Bike { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;

        public virtual Staff Staff { get; set; } = null!;
    }
}
