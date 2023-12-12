using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnitytFrameworrkTutorial.Migrations
{
    /// <inheritdoc />
    public partial class BookBorrowerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookBorrower",
                columns: table => new
                {
                    BooksBorrowedId = table.Column<int>(type: "int", nullable: false),
                    BorrowersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBorrower", x => new { x.BooksBorrowedId, x.BorrowersId });
                    table.ForeignKey(
                        name: "FK_BookBorrower_Books_BooksBorrowedId",
                        column: x => x.BooksBorrowedId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBorrower_Borrowers_BorrowersId",
                        column: x => x.BorrowersId,
                        principalTable: "Borrowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrower_BorrowersId",
                table: "BookBorrower",
                column: "BorrowersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBorrower");

            migrationBuilder.DropTable(
                name: "Borrowers");
        }
    }
}
