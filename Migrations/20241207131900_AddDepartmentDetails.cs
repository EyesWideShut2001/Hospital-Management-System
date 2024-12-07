using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Managment.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "MedicalStaffs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Accreditations",
                table: "Departments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Departments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FoundedDate",
                table: "Departments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Departments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainDoctor",
                table: "Departments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accreditations", "Description", "FoundedDate", "Location", "MainDoctor" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accreditations", "Description", "FoundedDate", "Location", "MainDoctor" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Accreditations", "Description", "FoundedDate", "Location", "MainDoctor" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Accreditations", "Description", "FoundedDate", "Location", "MainDoctor" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaffs_DepartmentId",
                table: "MedicalStaffs",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaffs_Departments_DepartmentId",
                table: "MedicalStaffs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaffs_Departments_DepartmentId",
                table: "MedicalStaffs");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaffs_DepartmentId",
                table: "MedicalStaffs");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "MedicalStaffs");

            migrationBuilder.DropColumn(
                name: "Accreditations",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "FoundedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "MainDoctor",
                table: "Departments");
        }
    }
}
