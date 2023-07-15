using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        [Required(ErrorMessage = "The OrderId field is required.")]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "The ProductId field is required.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "The Quantity field is required.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "The Price field is required.")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
