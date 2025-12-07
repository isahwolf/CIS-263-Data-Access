using Microsoft.EntityFrameworkCore.Migrations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

#nullable disable

namespace Books.Migrations
{
    /// <inheritdoc />
    public partial class view : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER VIEW AuthorTitleNameView
                AS
                SELECT Authors.FirstName, Authors.LastName, Titles.BookTitle
                FROM Authors, Titles, AuthorTitles
                WHERE Authors.AuthorId = AuthorTitles.AuthorId AND
                Titles.ISBN = AuthorTitles.ISBN AND Authors.LastName = 'Deitel' AND Titles.BookTitle LIKE '%Java%'
                ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
