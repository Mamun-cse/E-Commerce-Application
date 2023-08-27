using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ECommerceProject_API.Model
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        // Navigation Prope]rties
        //[JsonIgnore]
        //public User? User { get; set; }
        //[JsonIgnore]
        //public Product? Product { get; set; }
    }
}
