using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogrenc.DataAccess.Migrations
{
    public partial class db6_1 : Migration
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
                name: "Derss",
                columns: table => new
                {
                    IdDers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derss", x => x.IdDers);
                    table.ForeignKey(
                        name: "FK_Derss_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "IdBolum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    IdOgrenci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAnadal = table.Column<int>(type: "int", nullable: false),
                    IdYanDal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.IdOgrenci);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_IdAnadal",
                        column: x => x.IdAnadal,
                        principalTable: "Bolums",
                        principalColumn: "IdBolum",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_IdYanDal",
                        column: x => x.IdYanDal,
                        principalTable: "Bolums",
                        principalColumn: "IdBolum");
                });

            migrationBuilder.CreateTable(
                name: "DonemDersleris",
                columns: table => new
                {
                    IdDonem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersIdDers = table.Column<int>(type: "int", nullable: true),
                    OgrenciIdOgrenci = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonemDersleris", x => x.IdDonem);
                    table.ForeignKey(
                        name: "FK_DonemDersleris_Derss_DersIdDers",
                        column: x => x.DersIdDers,
                        principalTable: "Derss",
                        principalColumn: "IdDers");
                    table.ForeignKey(
                        name: "FK_DonemDersleris_Ogrencis_OgrenciIdOgrenci",
                        column: x => x.OgrenciIdOgrenci,
                        principalTable: "Ogrencis",
                        principalColumn: "IdOgrenci");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Derss_BolumId",
                table: "Derss",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_DonemDersleris_DersIdDers",
                table: "DonemDersleris",
                column: "DersIdDers");

            migrationBuilder.CreateIndex(
                name: "IX_DonemDersleris_OgrenciIdOgrenci",
                table: "DonemDersleris",
                column: "OgrenciIdOgrenci");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_IdAnadal",
                table: "Ogrencis",
                column: "IdAnadal");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_IdYanDal",
                table: "Ogrencis",
                column: "IdYanDal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonemDersleris");

            migrationBuilder.DropTable(
                name: "Derss");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Bolums");
        }
    }
}
