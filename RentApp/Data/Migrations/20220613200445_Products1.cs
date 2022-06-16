using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentApp.Data.Migrations
{
    public partial class Products1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppsName",
                schema: "data",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppsName",
                schema: "data",
                table: "Products");
        }
    }
}
