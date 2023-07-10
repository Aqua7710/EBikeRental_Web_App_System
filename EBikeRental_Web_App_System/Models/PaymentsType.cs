using System.ComponentModel.DataAnnotations;

namespace EBikeRental_Web_App_System.Models
{
    public class PaymentsType
    {
        [Key]
        [Display(Name = "Payment Type ID")]
        public int PaymentsTypeId { get; set; } // payment type id

        [Display(Name = "Payment Type")]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        [Required]
        public string PaymentType { get; set; } = null!; // payment type with string length max: 50, min: 2

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
