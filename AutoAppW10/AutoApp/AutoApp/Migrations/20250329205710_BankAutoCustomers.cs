using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoApp.Migrations
{
    /// <inheritdoc />
    public partial class BankAutoCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                CREATE OR ALTER VIEW BankAutoCustomers AS
                SELECT Banks.Name, Customers.FirstName, Customers.LastName
                FROM Banks, Autos, Sales, Customers
                WHERE Banks.RoutingNum = Autos.RoutingNum AND
                Autos.VIN = Sales.VIN AND
                Sales.Email = Customers.Email

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                DROP VIEW IF EXISTS BankAutoCustomers

            ");
        }
    }
}
