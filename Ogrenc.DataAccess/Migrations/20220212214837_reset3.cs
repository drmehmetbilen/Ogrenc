using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogrenc.DataAccess.Migrations
{
    public partial class reset3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgretimElemans_Bolums_idBolum",
                table: "OgretimElemans");

            migrationBuilder.AlterColumn<int>(
                name: "idBolum",
                table: "OgretimElemans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OgretimElemans_Bolums_idBolum",
                table: "OgretimElemans",
                column: "idBolum",
                principalTable: "Bolums",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgretimElemans_Bolums_idBolum",
                table: "OgretimElemans");

            migrationBuilder.AlterColumn<int>(
                name: "idBolum",
                table: "OgretimElemans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OgretimElemans_Bolums_idBolum",
                table: "OgretimElemans",
                column: "idBolum",
                principalTable: "Bolums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
