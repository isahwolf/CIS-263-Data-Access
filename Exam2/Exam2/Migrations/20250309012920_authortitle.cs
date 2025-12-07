using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam2.Migrations
{
    /// <inheritdoc />
    public partial class authortitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorTitles",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorTitles", x => new { x.ISBN, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_AuthorTitles_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorTitles_Titles_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Titles",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorTitles_AuthorId",
                table: "AuthorTitles",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorTitles");
        }
    }
}
