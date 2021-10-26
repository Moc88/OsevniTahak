using Microsoft.EntityFrameworkCore.Migrations;

namespace OsevniTahak.Data.Migrations
{
    public partial class Prvni_Migrace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odruda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vyrobce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Podrobnosti = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crop");

            migrationBuilder.DropTable(
                name: "Family");
        }
    }
}
