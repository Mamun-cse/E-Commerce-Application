using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        [Required(ErrorMessage = "The CartId field is required.")]
        public int CartId { get; set; }
        [Required(ErrorMessage = "The ProductId field is required.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "The Quantity field is required.")]
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
