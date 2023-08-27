using ECommerceProject_API.Model;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject_API.Data
{
    public class ECommerceDbContext:DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductCategory>().HasData(
            new ProductCategory
            {
                Id = 1,
                Name = "Laptop",
                IsDeleted = false
            },

            new ProductCategory
            {
                Id = 2,
                Name = "Mouse",
                IsDeleted = false
            },
            new ProductCategory
            {
                Id = 3,
                Name = "Phone",
                IsDeleted = false
            }


        );

            // Add seed data here
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Product 1",
                    ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Price = 200,
                    ProductCategoryId = 1,
                    ImageUrl = "https://images.unsplash.com/photo-1618424181497-157f25b6ddd5?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8bGFwdG9wJTIwY29tcHV0ZXJ8ZW58MHx8MHx8fDA%3D&w=1000&q=80",
                    Discount = 10,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Product 2",
                    ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Price = 100,
                    ProductCategoryId = 2,
                    ImageUrl = "https://images.unsplash.com/flagged/photo-1561023367-4431103a484f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NXx8Y29tcHV0ZXIlMjBtb3VzZXxlbnwwfHwwfHx8MA%3D%3D&w=1000&q=80",
                    Discount = 10,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Product 3",
                    ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Price = 200,
                    ProductCategoryId = 1,
                    ImageUrl = "https://images.unsplash.com/photo-1603302576837-37561b2e2302?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGxhcHRvcHxlbnwwfHwwfHx8MA%3D%3D&w=1000&q=80",
                    Discount = 10,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Product 4",
                    ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Price = 150,
                    ProductCategoryId = 3,
                    ImageUrl = "https://waltonbd.com/image/catalog/home-page/half-block/nexg-n6-block.jpg",
                    Discount = 10,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Product 5",
                    ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Price = 100,
                    ProductCategoryId = 2,
                    ImageUrl = "https://i.rtings.com/assets/products/1htouLNw/amazonbasics-3-button-usb-wired-mouse/design-medium.jpg",
                    Discount = 10,
                    IsDeleted = false
                }

            );

        }

        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; set; }

    }
        
       
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Review> Reviews { get; set; }

    
}
