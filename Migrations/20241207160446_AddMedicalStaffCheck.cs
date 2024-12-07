using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Managment.Migrations
{
    /// <inheritdoc />
    public partial class AddMedicalStaffCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "MedicalStaffs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "MedicalStaffs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "MedicalStaffs",
                columns: new[] { "Id", "AdminId", "DepartmentId", "Name", "PasswordHash" },
                values: new object[] { 1, 1, 1, "Sara", "$2a$12$RvBnjdK5vod8qb02w0ZxzuafaeDZ5hUyjM.x2E1tEsardDL5tiA0y" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "MedicalStaffs");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "MedicalStaffs");
        }
    }
}
