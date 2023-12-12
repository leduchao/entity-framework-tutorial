using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnitytFrameworrkTutorial.Migrations
{
    /// <inheritdoc />
    public partial class ThemCacDonViHanhChinh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhSachLoaiXe",
                columns: table => new
                {
                    MaLoaiXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachLoaiXe", x => x.MaLoaiXe);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachTinh",
                columns: table => new
                {
                    MaTinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachTinh", x => x.MaTinh);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachHuyen",
                columns: table => new
                {
                    MaHuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTinh = table.Column<int>(type: "int", nullable: false),
                    TinhMaTinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachHuyen", x => x.MaHuyen);
                    table.ForeignKey(
                        name: "FK_DanhSachHuyen_DanhSachTinh_TinhMaTinh",
                        column: x => x.TinhMaTinh,
                        principalTable: "DanhSachTinh",
                        principalColumn: "MaTinh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachXa",
                columns: table => new
                {
                    MaXa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenXa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHuyen = table.Column<int>(type: "int", nullable: false),
                    HuyenMaHuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachXa", x => x.MaXa);
                    table.ForeignKey(
                        name: "FK_DanhSachXa_DanhSachHuyen_HuyenMaHuyen",
                        column: x => x.HuyenMaHuyen,
                        principalTable: "DanhSachHuyen",
                        principalColumn: "MaHuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachThon",
                columns: table => new
                {
                    MaThon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaXa = table.Column<int>(type: "int", nullable: false),
                    XaMaXa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachThon", x => x.MaThon);
                    table.ForeignKey(
                        name: "FK_DanhSachThon_DanhSachXa_XaMaXa",
                        column: x => x.XaMaXa,
                        principalTable: "DanhSachXa",
                        principalColumn: "MaXa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachHuyen_TinhMaTinh",
                table: "DanhSachHuyen",
                column: "TinhMaTinh");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachThon_XaMaXa",
                table: "DanhSachThon",
                column: "XaMaXa");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachXa_HuyenMaHuyen",
                table: "DanhSachXa",
                column: "HuyenMaHuyen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhSachLoaiXe");

            migrationBuilder.DropTable(
                name: "DanhSachThon");

            migrationBuilder.DropTable(
                name: "DanhSachXa");

            migrationBuilder.DropTable(
                name: "DanhSachHuyen");

            migrationBuilder.DropTable(
                name: "DanhSachTinh");
        }
    }
}
