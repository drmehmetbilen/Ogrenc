using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogrenc.DataAccess.Migrations
{
    public partial class reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnaDalId = table.Column<int>(type: "int", nullable: true),
                    YanDalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_AnaDalId",
                        column: x => x.AnaDalId,
                        principalTable: "Bolums",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_YanDalId",
                        column: x => x.YanDalId,
                        principalTable: "Bolums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgretimElemans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SicilNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    idBolum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimElemans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretimElemans_Bolums_idBolum",
                        column: x => x.idBolum,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Kredi = table.Column<int>(type: "int", nullable: false),
                    Saat = table.Column<int>(type: "int", nullable: false),
                    IdBolum = table.Column<int>(type: "int", nullable: true),
                    IdOgretimElemani = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ders_Bolums_IdBolum",
                        column: x => x.IdBolum,
                        principalTable: "Bolums",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ders_OgretimElemans_IdOgretimElemani",
                        column: x => x.IdOgretimElemani,
                        principalTable: "OgretimElemans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ders_IdBolum",
                table: "Ders",
                column: "IdBolum");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_IdOgretimElemani",
                table: "Ders",
                column: "IdOgretimElemani");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_AnaDalId",
                table: "Ogrencis",
                column: "AnaDalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_YanDalId",
                table: "Ogrencis",
                column: "YanDalId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemans_idBolum",
                table: "OgretimElemans",
                column: "idBolum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "OgretimElemans");

            migrationBuilder.DropTable(
                name: "Bolums");
        }
    }
}
