namespace EBikeRental_Web_App_System.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public decimal TotalCost { get; set; }

        public int PaymentsTypeId { get; set; }

        public DateTime? PaymentDate { get; set; }

        public bool PaymentStatus { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

        public virtual PaymentsType PaymentsType { get; set; } = null!;
    }
}
