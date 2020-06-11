using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class UrunMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    indirimlifiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    urunozellik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resim2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.UrunId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uruns");
        }
    }
}
