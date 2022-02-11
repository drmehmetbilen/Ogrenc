using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogrenc.DataAccess.Migrations
{
    public partial class x1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    IdBolum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.IdBolum);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    IdOgrenci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnaDalId = table.Column<int>(type: "int", nullable: true),
                    YanDalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.IdOgrenci);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_AnaDalId",
                        column: x => x.AnaDalId,
                        principalTable: "Bolums",
                        principalColumn: "IdBolum");
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_YanDalId",
                        column: x => x.YanDalId,
                        principalTable: "Bolums",
                        principalColumn: "IdBolum");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_AnaDalId",
                table: "Ogrencis",
                column: "AnaDalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_YanDalId",
                table: "Ogrencis",
                column: "YanDalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Bolums");
        }
    }
}
