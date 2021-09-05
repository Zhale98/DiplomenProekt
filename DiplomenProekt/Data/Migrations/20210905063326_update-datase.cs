using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DiplomenProekt.Data.Migrations
{
    public partial class updatedatase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervacii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Smqna = table.Column<string>(type: "text", nullable: true),
                    Kategoriq = table.Column<string>(type: "text", nullable: true),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "text", nullable: true),
                    Familiq = table.Column<string>(type: "text", nullable: true),
                    Bungalo = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacii", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervacii");
        }
    }
}
