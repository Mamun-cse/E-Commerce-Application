using System.ComponentModel.DataAnnotations;

namespace ECommerceProject_API.Model
{
    public class ProductCategory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       // public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}
