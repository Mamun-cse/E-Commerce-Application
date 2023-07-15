using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Required(ErrorMessage = "The UserId field is required.")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "The ProductId field is required.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "The Rating field is required.")]
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
