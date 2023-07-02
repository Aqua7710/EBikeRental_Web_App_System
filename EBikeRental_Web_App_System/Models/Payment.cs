using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EBikeRental_Web_App_System.Models
{
    public class Payment
    {
        [Display(Name = "Payment ID")]
        public int PaymentId { get; set; }
        [Display(Name = "Total Cost")]
        [DataType(DataType.Currency)]
        public decimal TotalCost { get; set; }
        public int PaymentsTypeId { get; set; }
        [Display(Name = "Payment date")]
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "Payment complete")]
        public bool PaymentStatus { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
        [Display(Name = "Payment Type")]
        public virtual PaymentsType PaymentsType { get; set; } = null!;
    }
}
