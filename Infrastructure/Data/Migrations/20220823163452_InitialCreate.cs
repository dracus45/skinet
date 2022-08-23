using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyCounty = table.Column<string>(type: "TEXT", nullable: true),
                    Bank1 = table.Column<string>(type: "TEXT", nullable: true),
                    Account1 = table.Column<string>(type: "TEXT", nullable: true),
                    Bank2 = table.Column<string>(type: "TEXT", nullable: true),
                    Account2 = table.Column<string>(type: "TEXT", nullable: true),
                    Bank3 = table.Column<string>(type: "TEXT", nullable: true),
                    Account3 = table.Column<string>(type: "TEXT", nullable: true),
                    Cui = table.Column<string>(type: "TEXT", nullable: true),
                    Register = table.Column<string>(type: "TEXT", nullable: true),
                    InvoiceSeries = table.Column<string>(type: "TEXT", nullable: true),
                    InvoiceFirst = table.Column<int>(type: "INTEGER", nullable: false),
                    InvoiceLast = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceiptSeries = table.Column<string>(type: "TEXT", nullable: true),
                    ReceiptFirst = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceiptLast = table.Column<int>(type: "INTEGER", nullable: false),
                    Vat = table.Column<int>(type: "INTEGER", nullable: false),
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductCompanyId = table.Column<int>(type: "INTEGER", nullable: false),
                    Um = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Currency = table.Column<int>(type: "INTEGER", nullable: false),
                    Vat = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCompanies_ProductCompanyId",
                        column: x => x.ProductCompanyId,
                        principalTable: "ProductCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCompanyId",
                table: "Products",
                column: "ProductCompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductCompanies");
        }
    }
}
