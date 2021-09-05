using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiplomenProekt.Data.Migrations
{
    public partial class rezervacii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Do",
                table: "Rezervacii",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Ot",
                table: "Rezervacii",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Do",
                table: "Rezervacii");

            migrationBuilder.DropColumn(
                name: "Ot",
                table: "Rezervacii");
        }
    }
}
