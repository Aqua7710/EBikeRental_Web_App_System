using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EBikeRental_Web_App_System.Models
{
    public class Payment
    {
        [Display(Name = "Payment ID")]
        public int PaymentId { get; set; } // payment id


        [Display(Name = "Total Cost")]
        [DataType(DataType.Currency)]
        [Range(minimum: 0, maximum: 999)]
        [Required]
        public decimal TotalCost { get; set; } // total cost (type: currency), min: $0, max: $999


        public int PaymentsTypeId { get; set; }

        
        [Display(Name = "Payment date")]
        [DataType(DataType.Date)]
        public DateTime? PaymentDate { get; set; } // payment date (type: date) NOT REQUIRED


        [Display(Name = "Payment complete")]
        public bool PaymentStatus { get; set; } // payment status 



        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
        [Display(Name = "Payment Type")]
        public virtual PaymentsType PaymentsType { get; set; } = null!;
    }
}
