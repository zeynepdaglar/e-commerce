using Microsoft.EntityFrameworkCore.Migrations;

namespace Zeynep.Ecommerse.BusinessLogic.Migrations
{
    public partial class Product_img : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductPhoto1",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductPhoto2",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductPhoto3",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPhoto1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPhoto2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPhoto3",
                table: "Products");
        }
    }
}
