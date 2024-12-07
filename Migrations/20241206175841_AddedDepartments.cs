using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Managment.Migrations
{
    /// <inheritdoc />
    public partial class AddedDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Departments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdminId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdminId", "DepartmentName" },
                values: new object[] { 2, "Pediatrics" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdminId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AdminId",
                table: "Departments",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Admins_AdminId",
                table: "Departments",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Admins_AdminId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_AdminId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Departments");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DepartmentName",
                value: "Pneumology");
        }
    }
}
