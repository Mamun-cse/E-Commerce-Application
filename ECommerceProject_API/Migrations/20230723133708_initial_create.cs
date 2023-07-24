using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceProject_API.Migrations
{
    /// <inheritdoc />
    public partial class initial_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Laptop" },
                    { 2, false, "Mouse" },
                    { 3, false, "Phone" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discount", "ImageUrl", "IsDeleted", "Price", "ProductCategoryId", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, 10m, "https://images.unsplash.com/photo-1618424181497-157f25b6ddd5?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8bGFwdG9wJTIwY29tcHV0ZXJ8ZW58MHx8MHx8fDA%3D&w=1000&q=80", false, 200m, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Product 1" },
                    { 2, 10m, "https://images.unsplash.com/flagged/photo-1561023367-4431103a484f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NXx8Y29tcHV0ZXIlMjBtb3VzZXxlbnwwfHwwfHx8MA%3D%3D&w=1000&q=80", false, 100m, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Product 2" },
                    { 3, 10m, "https://images.unsplash.com/photo-1603302576837-37561b2e2302?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGxhcHRvcHxlbnwwfHwwfHx8MA%3D%3D&w=1000&q=80", false, 200m, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Product 3" },
                    { 4, 10m, "https://waltonbd.com/image/catalog/home-page/half-block/nexg-n6-block.jpg", false, 150m, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Product 4" },
                    { 5, 10m, "https://i.rtings.com/assets/products/1htouLNw/amazonbasics-3-button-usb-wired-mouse/design-medium.jpg", false, 100m, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Product 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
