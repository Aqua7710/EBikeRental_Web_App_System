using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Bike
    {
        [Display(Name = "Bike ID")]
        public int BikeId { get; set; } // bike id


        [Display(Name = "Bike Model")]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Required]
        public string BikeModel { get; set; } = null!; // bike model max:50, min:3


        [Display(Name = "Bike Specs")]
        [StringLength(maximumLength: 256, MinimumLength = 10)]
        [DataType(DataType.Text)]
        public string BikeSpecs { get; set; } = null!; // bike specs max: 256, min:10


        [Display(Name = "Stock Quantity")]
        [Range(maximum: 99, minimum: 1)]
        public double StockQuantity { get; set; } // stock quantity max: 99, min: 1


        [Display(Name = "Cost per day")]
        [DataType(DataType.Currency)]
        [Range(maximum: 999, minimum: 0)]
        public decimal CostPerDay { get; set; } // cost per day max: $999, min: $0



        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
