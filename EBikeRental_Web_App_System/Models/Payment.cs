using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }
        [Display(Name = "Payment Type ID")]
        public int PaymentsTypeId { get; set; }
        [Display(Name = "Payment date")]
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "Payment complete")]
        public bool PaymentStatus { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

        public virtual PaymentsType PaymentsType { get; set; } = null!;
    }
}
