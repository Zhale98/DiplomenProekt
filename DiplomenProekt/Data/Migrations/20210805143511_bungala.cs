using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DiplomenProekt.Data.Migrations
{
    public partial class bungala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bungala_statut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Opisanie = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bungala_statut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tip_Bungala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Legla = table.Column<double>(type: "double", nullable: false),
                    Hora = table.Column<double>(type: "double", nullable: false),
                    Hladilnik = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Sanitaren_vazel = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tip_Bungala", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vidove_Legla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Kapacitet = table.Column<int>(type: "int", nullable: false),
                    Opisanie = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vidove_Legla", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Legla_v_Bungala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Bungalo_tip_id = table.Column<int>(type: "int", nullable: false),
                    Vid_leglo_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legla_v_Bungala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Legla_v_Bungala_Tip_Bungala_Bungalo_tip_id",
                        column: x => x.Bungalo_tip_id,
                        principalTable: "Tip_Bungala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Legla_v_Bungala_Vidove_Legla_Vid_leglo_id",
                        column: x => x.Vid_leglo_id,
                        principalTable: "Vidove_Legla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Legla_v_Bungala_Bungalo_tip_id",
                table: "Legla_v_Bungala",
                column: "Bungalo_tip_id");

            migrationBuilder.CreateIndex(
                name: "IX_Legla_v_Bungala_Vid_leglo_id",
                table: "Legla_v_Bungala",
                column: "Vid_leglo_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bungala_statut");

            migrationBuilder.DropTable(
                name: "Legla_v_Bungala");

            migrationBuilder.DropTable(
                name: "Tip_Bungala");

            migrationBuilder.DropTable(
                name: "Vidove_Legla");
        }
    }
}
