using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoRentRevive.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreatedById", "CreatedTime", "GroupName", "UpdatedById", "UpdatedTime" },
                values: new object[] { 0, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "", 0, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreatedById", "CreatedTime", "GroupName", "UpdatedById", "UpdatedTime" },
                values: new object[] { 0, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "", 0, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreatedById", "CreatedTime", "GroupName", "UpdatedById", "UpdatedTime" },
                values: new object[] { 0, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "", 0, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreatedById", "CreatedTime", "GroupName", "UpdatedById", "UpdatedTime" },
                values: new object[] { 0, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "", 0, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "CreatedById", "CreatedTime", "GroupName", "UpdatedById", "UpdatedTime" },
                values: new object[] { 0, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "", 0, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "CreatedById", "CreatedTime", "GroupName", "UpdatedById", "UpdatedTime" },
                values: new object[] { 0, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "", 0, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedById", "UpdatedById" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedById", "UpdatedById" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedById", "UpdatedById" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedById", "UpdatedById" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedById", "UpdatedById" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Departments");
        }
    }
}
