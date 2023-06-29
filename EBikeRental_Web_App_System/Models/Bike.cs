using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Bike
    {
        [Display(Name = "Bike ID")]
        public int BikeId { get; set; }
        [Display(Name = "Bike Model")]
        public string BikeModel { get; set; } = null!;
        [Display(Name = "Bike Specs")]
        public string BikeSpecs { get; set; } = null!;
        [Display(Name = "Stock Quantity")]
        public double StockQuantity { get; set; }
        [Display(Name = "Cost per dayW")]
        public decimal CostPerDay { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
