using Microsoft.EntityFrameworkCore.Migrations;

namespace DiplomenProekt.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dete_10",
                table: "Rezervacii",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dete_12",
                table: "Rezervacii",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dete_7",
                table: "Rezervacii",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dete_10",
                table: "Rezervacii");

            migrationBuilder.DropColumn(
                name: "Dete_12",
                table: "Rezervacii");

            migrationBuilder.DropColumn(
                name: "Dete_7",
                table: "Rezervacii");
        }
    }
}
