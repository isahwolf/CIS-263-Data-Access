using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercise11.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.EnsureSchema(
                name: "HumanResources");

            migrationBuilder.EnsureSchema(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Person records."),
                    PersonType = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: false, comment: "Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact"),
                    NameStyle = table.Column<bool>(type: "bit", nullable: false, comment: "0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order."),
                    Title = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true, comment: "A courtesy title. For example, Mr. or Ms."),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "First name of the person."),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Middle name or middle initial of the person."),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last name of the person."),
                    Suffix = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Surname suffix. For example, Sr. or Jr."),
                    EmailPromotion = table.Column<int>(type: "int", nullable: false, comment: "0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. "),
                    AdditionalContactInfo = table.Column<string>(type: "xml", nullable: true, comment: "Additional contact information about the person stored in xml format. "),
                    Demographics = table.Column<string>(type: "xml", nullable: true, comment: "Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_BusinessEntityID", x => x.BusinessEntityID);
                },
                comment: "Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.");

            migrationBuilder.CreateTable(
                name: "SalesTerritory",
                schema: "Sales",
                columns: table => new
                {
                    TerritoryID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for SalesTerritory records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Sales territory description"),
                    CountryRegionCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. "),
                    Group = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Geographic area to which the sales territory belong."),
                    SalesYTD = table.Column<decimal>(type: "money", nullable: false, comment: "Sales in the territory year to date."),
                    SalesLastYear = table.Column<decimal>(type: "money", nullable: false, comment: "Sales in the territory the previous year."),
                    CostYTD = table.Column<decimal>(type: "money", nullable: false, comment: "Business costs in the territory year to date."),
                    CostLastYear = table.Column<decimal>(type: "money", nullable: false, comment: "Business costs in the territory the previous year."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTerritory_TerritoryID", x => x.TerritoryID);
                },
                comment: "Sales territory lookup table.");

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "HumanResources",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID."),
                    NationalIDNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Unique national identification number such as a social security number."),
                    LoginID = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "Network login."),
                    OrganizationLevel = table.Column<short>(type: "smallint", nullable: true, computedColumnSql: "([OrganizationNode].[GetLevel]())", stored: false, comment: "The depth of the employee in the corporate hierarchy."),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Work title such as Buyer or Sales Representative."),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false, comment: "Date of birth."),
                    MaritalStatus = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false, comment: "M = Married, S = Single"),
                    Gender = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false, comment: "M = Male, F = Female"),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false, comment: "Employee hired on this date."),
                    SalariedFlag = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining."),
                    VacationHours = table.Column<short>(type: "smallint", nullable: false, comment: "Number of available vacation hours."),
                    SickLeaveHours = table.Column<short>(type: "smallint", nullable: false, comment: "Number of available sick leave hours."),
                    CurrentFlag = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "0 = Inactive, 1 = Active"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_BusinessEntityID", x => x.BusinessEntityID);
                    table.ForeignKey(
                        name: "FK_Employee_Person_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityID");
                },
                comment: "Employee information such as salary, department, and title.");

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "Sales",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: true, comment: "Foreign key to Person.BusinessEntityID"),
                    StoreID = table.Column<int>(type: "int", nullable: true, comment: "Foreign key to Store.BusinessEntityID"),
                    TerritoryID = table.Column<int>(type: "int", nullable: true, comment: "ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID."),
                    AccountNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, computedColumnSql: "(isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),''))", stored: false, comment: "Unique number identifying the customer assigned by the accounting system."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_CustomerID", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Person_PersonID",
                        column: x => x.PersonID,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityID");
                    table.ForeignKey(
                        name: "FK_Customer_SalesTerritory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryID");
                },
                comment: "Current customer information. Also see the Person and Store tables.");

            migrationBuilder.CreateTable(
                name: "SalesPerson",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID"),
                    TerritoryID = table.Column<int>(type: "int", nullable: true, comment: "Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID."),
                    SalesQuota = table.Column<decimal>(type: "money", nullable: true, comment: "Projected yearly sales."),
                    Bonus = table.Column<decimal>(type: "money", nullable: false, comment: "Bonus due if quota is met."),
                    CommissionPct = table.Column<decimal>(type: "smallmoney", nullable: false, comment: "Commision percent received per sale."),
                    SalesYTD = table.Column<decimal>(type: "money", nullable: false, comment: "Sales total year to date."),
                    SalesLastYear = table.Column<decimal>(type: "money", nullable: false, comment: "Sales total of previous year."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPerson_BusinessEntityID", x => x.BusinessEntityID);
                    table.ForeignKey(
                        name: "FK_SalesPerson_Employee_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityID");
                    table.ForeignKey(
                        name: "FK_SalesPerson_SalesTerritory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryID");
                },
                comment: "Sales representative current information.");

            migrationBuilder.CreateTable(
                name: "SalesOrderHeader",
                schema: "Sales",
                columns: table => new
                {
                    SalesOrderID = table.Column<int>(type: "int", nullable: false, comment: "Primary key.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevisionNumber = table.Column<byte>(type: "tinyint", nullable: false, comment: "Incremental number to track changes to the sales order over time."),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Dates the sales order was created."),
                    DueDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Date the order is due to the customer."),
                    ShipDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Date the order was shipped to the customer."),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1, comment: "Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled"),
                    OnlineOrderFlag = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "0 = Order placed by sales person. 1 = Order placed online by customer."),
                    SalesOrderNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, computedColumnSql: "(isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***'))", stored: false, comment: "Unique sales order identification number."),
                    PurchaseOrderNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true, comment: "Customer purchase order number reference. "),
                    AccountNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, comment: "Financial accounting number reference."),
                    CustomerID = table.Column<int>(type: "int", nullable: false, comment: "Customer identification number. Foreign key to Customer.BusinessEntityID."),
                    SalesPersonID = table.Column<int>(type: "int", nullable: true, comment: "Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID."),
                    TerritoryID = table.Column<int>(type: "int", nullable: true, comment: "Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID."),
                    BillToAddressID = table.Column<int>(type: "int", nullable: false, comment: "Customer billing address. Foreign key to Address.AddressID."),
                    ShipToAddressID = table.Column<int>(type: "int", nullable: false, comment: "Customer shipping address. Foreign key to Address.AddressID."),
                    ShipMethodID = table.Column<int>(type: "int", nullable: false, comment: "Shipping method. Foreign key to ShipMethod.ShipMethodID."),
                    CreditCardID = table.Column<int>(type: "int", nullable: true, comment: "Credit card identification number. Foreign key to CreditCard.CreditCardID."),
                    CreditCardApprovalCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true, comment: "Approval code provided by the credit card company."),
                    CurrencyRateID = table.Column<int>(type: "int", nullable: true, comment: "Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID."),
                    SubTotal = table.Column<decimal>(type: "money", nullable: false, comment: "Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID."),
                    TaxAmt = table.Column<decimal>(type: "money", nullable: false, comment: "Tax amount."),
                    Freight = table.Column<decimal>(type: "money", nullable: false, comment: "Shipping cost."),
                    TotalDue = table.Column<decimal>(type: "money", nullable: false, computedColumnSql: "(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))", stored: false, comment: "Total due from customer. Computed as Subtotal + TaxAmt + Freight."),
                    Comment = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, comment: "Sales representative comments."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderHeader_SalesOrderID", x => x.SalesOrderID);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalSchema: "Sales",
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_SalesPerson_SalesPersonID",
                        column: x => x.SalesPersonID,
                        principalSchema: "Sales",
                        principalTable: "SalesPerson",
                        principalColumn: "BusinessEntityID");
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_SalesTerritory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryID");
                },
                comment: "General sales order information.");

            migrationBuilder.CreateTable(
                name: "SalesTerritoryHistory",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID."),
                    TerritoryID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID."),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Primary key. Date the sales representive started work in the territory."),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Date the sales representative left work in the territory."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID", x => new { x.BusinessEntityID, x.StartDate, x.TerritoryID });
                    table.ForeignKey(
                        name: "FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Sales",
                        principalTable: "SalesPerson",
                        principalColumn: "BusinessEntityID");
                    table.ForeignKey(
                        name: "FK_SalesTerritoryHistory_SalesTerritory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryID");
                },
                comment: "Sales representative transfers to other sales territories.");

            migrationBuilder.CreateTable(
                name: "SalesOrderDetail",
                schema: "Sales",
                columns: table => new
                {
                    SalesOrderID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Foreign key to SalesOrderHeader.SalesOrderID."),
                    SalesOrderDetailID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. One incremental unique number per product sold.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrierTrackingNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true, comment: "Shipment tracking number supplied by the shipper."),
                    OrderQty = table.Column<short>(type: "smallint", nullable: false, comment: "Quantity ordered per product."),
                    ProductID = table.Column<int>(type: "int", nullable: false, comment: "Product sold to customer. Foreign key to Product.ProductID."),
                    SpecialOfferID = table.Column<int>(type: "int", nullable: false, comment: "Promotional code. Foreign key to SpecialOffer.SpecialOfferID."),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false, comment: "Selling price of a single product."),
                    UnitPriceDiscount = table.Column<decimal>(type: "money", nullable: false, comment: "Discount amount."),
                    LineTotal = table.Column<decimal>(type: "numeric(38,6)", nullable: false, computedColumnSql: "(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))", stored: false, comment: "Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID", x => new { x.SalesOrderID, x.SalesOrderDetailID });
                    table.ForeignKey(
                        name: "FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID",
                        column: x => x.SalesOrderID,
                        principalSchema: "Sales",
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderID",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Individual products associated with a specific sales order. See SalesOrderHeader.");

            migrationBuilder.CreateIndex(
                name: "AK_Customer_AccountNumber",
                schema: "Sales",
                table: "Customer",
                column: "AccountNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Customer_rowguid",
                schema: "Sales",
                table: "Customer",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PersonID",
                schema: "Sales",
                table: "Customer",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TerritoryID",
                schema: "Sales",
                table: "Customer",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "AK_Employee_LoginID",
                schema: "HumanResources",
                table: "Employee",
                column: "LoginID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Employee_NationalIDNumber",
                schema: "HumanResources",
                table: "Employee",
                column: "NationalIDNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Employee_rowguid",
                schema: "HumanResources",
                table: "Employee",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Person_rowguid",
                schema: "Person",
                table: "Person",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_LastName_FirstName_MiddleName",
                schema: "Person",
                table: "Person",
                columns: new[] { "LastName", "FirstName", "MiddleName" });

            migrationBuilder.CreateIndex(
                name: "PXML_Person_AddContact",
                schema: "Person",
                table: "Person",
                column: "AdditionalContactInfo");

            migrationBuilder.CreateIndex(
                name: "PXML_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "XMLPATH_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "XMLPROPERTY_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "XMLVALUE_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "AK_SalesOrderDetail_rowguid",
                schema: "Sales",
                table: "SalesOrderDetail",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetail_ProductID",
                schema: "Sales",
                table: "SalesOrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "AK_SalesOrderHeader_rowguid",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_SalesOrderHeader_SalesOrderNumber",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "SalesOrderNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CustomerID",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_SalesPersonID",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_TerritoryID",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "AK_SalesPerson_rowguid",
                schema: "Sales",
                table: "SalesPerson",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesPerson_TerritoryID",
                schema: "Sales",
                table: "SalesPerson",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "AK_SalesTerritory_Name",
                schema: "Sales",
                table: "SalesTerritory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_SalesTerritory_rowguid",
                schema: "Sales",
                table: "SalesTerritory",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_SalesTerritoryHistory_rowguid",
                schema: "Sales",
                table: "SalesTerritoryHistory",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesTerritoryHistory_TerritoryID",
                schema: "Sales",
                table: "SalesTerritoryHistory",
                column: "TerritoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesOrderDetail",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesTerritoryHistory",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesOrderHeader",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesPerson",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "SalesTerritory",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Person");
        }
    }
}
