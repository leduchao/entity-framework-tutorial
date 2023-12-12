using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnitytFrameworrkTutorial.Migrations
{
    /// <inheritdoc />
    public partial class XeMayVaBienSoXe_OneToOne_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XeMays_BienSos_MaBienSo",
                table: "XeMays");

            migrationBuilder.DropIndex(
                name: "IX_XeMays_MaBienSo",
                table: "XeMays");

            migrationBuilder.DropColumn(
                name: "MaBienSo",
                table: "XeMays");

            migrationBuilder.AddColumn<int>(
                name: "MaXeMay",
                table: "BienSos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BienSos_MaXeMay",
                table: "BienSos",
                column: "MaXeMay",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BienSos_XeMays_MaXeMay",
                table: "BienSos",
                column: "MaXeMay",
                principalTable: "XeMays",
                principalColumn: "MaXe",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BienSos_XeMays_MaXeMay",
                table: "BienSos");

            migrationBuilder.DropIndex(
                name: "IX_BienSos_MaXeMay",
                table: "BienSos");

            migrationBuilder.DropColumn(
                name: "MaXeMay",
                table: "BienSos");

            migrationBuilder.AddColumn<int>(
                name: "MaBienSo",
                table: "XeMays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_XeMays_MaBienSo",
                table: "XeMays",
                column: "MaBienSo");

            migrationBuilder.AddForeignKey(
                name: "FK_XeMays_BienSos_MaBienSo",
                table: "XeMays",
                column: "MaBienSo",
                principalTable: "BienSos",
                principalColumn: "MaBienSo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
