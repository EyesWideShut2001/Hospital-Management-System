using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Managment.Migrations
{
    /// <inheritdoc />
    public partial class adminCredentials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Email", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { 1, "alex@gmail.com", "1234", "Alex" },
                    { 2, "andrei@gmail.com", "5678", "Andrei" },
                    { 3, "marius@gmail.com", "1278", "Marius" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 3, "Pneumology" },
                    { 4, "Dermatology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "MedicalStaffs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dr. A" },
                    { 2, "Dr. B" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AssignedDoctorId", "DateOfBirth", "DepartmentId", "MedicalRecord", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Healthy", "John Doe" },
                    { 2, 2, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Healthy", "Jane Smith" }
                });
        }
    }
}
