using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoRentRevive.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Department_Code", "Department_Name", "IsActive" },
                values: new object[,]
                {
                    { 1, "IT", "Information Technology", true },
                    { 2, "HR", "Human Resource", true },
                    { 3, "FIN", "Finance", true },
                    { 4, "MKT", "Marketing", true },
                    { 5, "ADM", "Admin", true },
                    { 6, "PRL", "Payroll", true }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateofBirth", "DepartmentId", "Email", "FirstName", "Gender", "IsActive", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "johnDoe@gmail.com", "John", 0, true, "Doe" },
                    { 2, new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "janeSmith@gmail.com", "Jane", 1, true, "Smith" },
                    { 3, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "michaelBrown@gmail.com", "Michael", 0, true, "Brown" },
                    { 4, new DateTime(1995, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "emilyDavis@gmail.com", "Emily", 1, true, "Davis" },
                    { 6, new DateTime(1995, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "saraparker@gmail.com", "Sara", 1, true, "parker" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
