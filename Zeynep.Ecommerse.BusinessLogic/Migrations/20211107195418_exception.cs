using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zeynep.Ecommerse.BusinessLogic.Migrations
{
    public partial class exception : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlobalExceptions",
                columns: table => new
                {
                    ExceptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    StackTrace = table.Column<string>(type: "nvarchar(4000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalExceptions", x => x.ExceptionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalExceptions");
        }
    }
}
