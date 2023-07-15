using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "The UserId field is required.")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "The TotalAmount field is required.")]
        public decimal TotalAmount { get; set; }
        [Required(ErrorMessage = "The Status field is required.")]
        public string Status { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
