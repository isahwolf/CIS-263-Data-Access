using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoApp.Migrations
{
    /// <inheritdoc />
    public partial class GetBankCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER PROCEDURE GetBankCustomers
                @routingnum VARCHAR(50)
                AS
                BEGIN
                SELECT Banks.RoutingNum, Banks.Name, Customers.Email,
                Customers.FirstName, Customers.LastName
                FROM Banks, Autos, Sales, Customers
                WHERE Banks.RoutingNum = Autos.RoutingNum AND
                Autos.VIN = Sales.VIN AND
                Sales.Email = Customers.Email AND
                Banks.RoutingNum = @routingnum
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                DROP PROCEDURE GetBankCustomers
            ");
        }
    }
}
