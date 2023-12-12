using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnitytFrameworrkTutorial.Migrations
{
    /// <inheritdoc />
    public partial class ThemXeMayVaBienSoXe_OneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BienSos",
                columns: table => new
                {
                    MaBienSo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTinh = table.Column<int>(type: "int", nullable: false),
                    MaHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDinhDanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienSos", x => x.MaBienSo);
                });

            migrationBuilder.CreateTable(
                name: "XeMays",
                columns: table => new
                {
                    MaXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaBienSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XeMays", x => x.MaXe);
                    table.ForeignKey(
                        name: "FK_XeMays_BienSos_MaBienSo",
                        column: x => x.MaBienSo,
                        principalTable: "BienSos",
                        principalColumn: "MaBienSo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_XeMays_MaBienSo",
                table: "XeMays",
                column: "MaBienSo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XeMays");

            migrationBuilder.DropTable(
                name: "BienSos");
        }
    }
}
