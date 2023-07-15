using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [Required(ErrorMessage = "The OrderId field is required.")]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "The Amount field is required.")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "The PaymentMethod field is required.")]
        public string PaymentMethod { get; set; }
        [Required(ErrorMessage = "The TransactionId field is required.")]
        public string TransactionId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public virtual Order Order { get; set; }
    }
}
