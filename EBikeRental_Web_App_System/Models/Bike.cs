namespace EBikeRental_Web_App_System.Models
{
    public class Bike
    {
        public int BikeId { get; set; }

        public string BikeModel { get; set; } = null!;

        public string BikeSpecs { get; set; } = null!;

        public double StockQuantity { get; set; }

        public decimal CostPerDay { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
