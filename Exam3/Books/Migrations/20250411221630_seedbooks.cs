using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.Migrations
{
    /// <inheritdoc />
    public partial class seedbooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Paul", "Deitel" },
                    { 2, "Harvey", "Deitel" },
                    { 3, "Abbey", "Deitel" },
                    { 4, "Sue", "Black" },
                    { 5, "John", "Purple" },
                    { 6, "Tim", "Brown" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "ISBN", "BookTitle", "Edition", "Year" },
                values: new object[,]
                {
                    { "132151006", "Internet & World Wide Web How to Program", 1, 2025 },
                    { "132575655", "Java How to Program, Late Objects Version", 1, 2025 },
                    { "133406954", "Visual Basic 2012 How to Program", 1, 2025 },
                    { "133807800", "Java How to Program", 1, 2025 },
                    { "133965260", "iOS 8 for Programmers: An App-Driven Approach with Swift", 1, 2025 },
                    { "133976890", "C How to Program", 1, 2025 },
                    { "134021363", "Swift for Programmers", 1, 2025 },
                    { "134289366", "Android 6 for Programmers: An App-Driven Approach", 1, 2025 },
                    { "134444302", "Android How to Program", 1, 2025 },
                    { "134448235", "C++ How to Program", 1, 2025 },
                    { "134601548", "Visual C# How to Program", 1, 2025 }
                });

            migrationBuilder.InsertData(
                table: "AuthorTitles",
                columns: new[] { "AuthorId", "ISBN" },
                values: new object[,]
                {
                    { 1, "132151006" },
                    { 2, "132151006" },
                    { 1, "132575655" },
                    { 2, "132575655" },
                    { 1, "133406954" },
                    { 2, "133406954" },
                    { 3, "133406954" },
                    { 1, "133807800" },
                    { 2, "133807800" },
                    { 1, "133965260" },
                    { 2, "133965260" },
                    { 1, "133976890" },
                    { 2, "133976890" },
                    { 1, "134021363" },
                    { 2, "134021363" },
                    { 1, "134289366" },
                    { 2, "134289366" },
                    { 4, "134289366" },
                    { 1, "134444302" },
                    { 2, "134444302" },
                    { 1, "134448235" },
                    { 2, "134448235" },
                    { 3, "134448235" },
                    { 1, "134601548" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "132151006" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "132151006" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "132575655" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "132575655" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "133406954" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "133406954" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 3, "133406954" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "133807800" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "133807800" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "133965260" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "133965260" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "133976890" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "133976890" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "134021363" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "134021363" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "134289366" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "134289366" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 4, "134289366" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "134444302" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "134444302" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "134448235" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 2, "134448235" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 3, "134448235" });

            migrationBuilder.DeleteData(
                table: "AuthorTitles",
                keyColumns: new[] { "AuthorId", "ISBN" },
                keyValues: new object[] { 1, "134601548" });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "132151006");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "132575655");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "133406954");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "133807800");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "133965260");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "133976890");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "134021363");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "134289366");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "134444302");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "134448235");

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "ISBN",
                keyValue: "134601548");
        }
    }
}
