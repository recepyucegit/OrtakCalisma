using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CA_CodeFirst_Restoran.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Name", "PhoneNumber", "Position", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", "555-1234", "Garson", "Veli" },
                    { 2, new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayşe", "555-5678", "Aşçı", "Yılmaz" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Description", "EmployeeId", "OrderDate", "OrderName", "Price" },
                values: new object[,]
                {
                    { 3, "Taze sebzelerle hazırlanan salata", 3, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salata", 20.00m },
                    { 1, "Lezzetli kebap", 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kebap", 50.00m },
                    { 2, "İtalyan pizzası", 2, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pizza", 30.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
