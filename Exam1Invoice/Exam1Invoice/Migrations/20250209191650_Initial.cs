using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam1Invoice.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        Email = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
            //        LastName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        FirstName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        Address = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
            //        City = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        State = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
            //        ZipCode = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
            //        PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Customers");
        }
    }
}
