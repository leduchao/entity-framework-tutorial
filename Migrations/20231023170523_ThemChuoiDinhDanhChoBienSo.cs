using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnitytFrameworrkTutorial.Migrations
{
    /// <inheritdoc />
    public partial class ThemChuoiDinhDanhChoBienSo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChuoiDinhDanh",
                table: "BienSos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChuoiDinhDanh",
                table: "BienSos");
        }
    }
}
