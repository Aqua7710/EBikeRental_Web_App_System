using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class PaymentsType
    {
        [Key]
        [Display(Name = "Payment Type ID")]
        public int PaymentsTypeId { get; set; }
        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; } = null!;

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
