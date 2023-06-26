namespace EBikeRental_Web_App_System.Models
{
    public class PaymentsType
    {
        public int PaymentsTypeId { get; set; }

        public string PaymentType { get; set; } = null!;

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
