using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOLA.Server.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Order",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrderName",
                table: "Order",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Restaurant",
                table: "Order",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Restaurant",
                table: "Order");

            migrationBuilder.AddColumn<double>(
                name: "OrderTotal",
                table: "Order",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
