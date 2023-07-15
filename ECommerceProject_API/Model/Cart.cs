using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class Cart
    {
        public int CartId { get; set; }
        [Required(ErrorMessage = "The UserId field is required.")]
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public virtual User User { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
