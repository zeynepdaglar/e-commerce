using Microsoft.EntityFrameworkCore.Migrations;

namespace Zeynep.Ecommerse.BusinessLogic.Migrations
{
    public partial class OrderLine1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderName",
                table: "OrderLines",
                newName: "ProductName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "OrderLines",
                newName: "OrderName");
        }
    }
}
