using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject_API.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Product Name field is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "The Price field is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The CategoryId field is required.")]

        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }

        public string ImageUrl { get; set; }
        public decimal Discount { get; set; }
        public bool IsDeleted { get; set; }
        //public DateTime CreatedAt { get; set; } = DateTime.Now;
        ///[ForeignKey("ProductCategoryId")]
       // public virtual ProductCategory? ProductCategory { get; set; }
        //public virtual ICollection<CartItem> CartItems { get; set; }
       // public virtual ICollection<OrderItem> OrderItems { get; set; }
        //public virtual ICollection<Review> Reviews { get; set; }
    }
}
