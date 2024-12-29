using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Managment.Migrations
{
    /// <inheritdoc />
    public partial class MedicalStaffDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MedicalStaffs",
                columns: new[] { "Id", "AdminId", "DepartmentId", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { 2, 1, 1, "$2a$11$9Vhk6FakLIPw2oqITiyWd.5yT1RKRbg7FwZNBurvD9nLciLfmjoWm", "Carina" },
                    { 3, 1, 1, "$2a$11$xJEYrgnETzvowSCYAtPdlu13jhRZ6P02EZDF9d/XAOpW2Tq1nuSSi", "Flavius" },
                    { 4, 1, 1, "$2a$11$u5CL6ypkZPwLpRoMoN2GoO4pQ2N8HzDdvW1QD7zuIDDw9/lRnGlYy", "George" },
                    { 5, 1, 2, "$2a$11$2JQHdcU.6ZfS.WX5pLVPluy7uJq4kB/Cn0OqpwXpzKjcb8mL1Mu/S", "Maria" },
                    { 6, 1, 2, "$2a$11$n2lPnRp6jVuKY7219WD5seyMEQzq45jxc4AZzLPSyy5opKe2ypq7O", "Ilie" },
                    { 7, 1, 2, "$2a$11$FgkiwL3dvqrvu7O9mKuGaue8MucA5ImP283mKDCdo0kbY3fh7Jsum", "Vlad" },
                    { 8, 2, 1, "$2a$11$G6tVf7hR8ni7trHf0WZoXOUH7UbjDomgwos3Hrp1jMI7asE0vwM6a", "Cristi" },
                    { 9, 2, 1, "$2a$11$eU0vuoBKQt5kOMVx3SPO8upqtosPy/tFKrFvMgUbAfvRem/FB5dcq", "Serban" },
                    { 10, 2, 1, "$2a$11$o0UR5DQiiQq9zFm/QG28I.QCgxqZtgKhtPuklssaOvI7SiqHn3Zje", "Tudor" },
                    { 11, 2, 1, "$2a$11$g4zc2Jfj3I3RTUvft9Xj8elsh/Wz9Sdi8UW22cApp.tFf6RdPinCy", "Alexandra" },
                    { 12, 3, 1, "$2a$11$qrl93QvU3uPGlQIvIkfTQO3BrvYRGUC6Y/u0h7IKp4m9kPRNR/HG6", "Marc" },
                    { 13, 3, 1, "$2a$11$sTmnkC5GP3Dh49YA8Hix0edhTrpKNhuWAm7MN0uqle6c5CVTOaOYe", "Diana" },
                    { 14, 3, 1, "$2a$11$pau9CtSFoAs.mBn83PNW1OkonJWEheD4UKGCRHuOIEyLcmUDsHfsK", "Ana" },
                    { 15, 3, 1, "$2a$11$cp74W4PcfUh6FiAvAgDon.ihBt2cbBDk5hB1Vtb5oY2tnxtmntvVe", "Dan" },
                    { 16, 3, 1, "$2a$11$vreICMp6.M3Z9MwUEY/TOupC05lYNJASV5S63x9LbYERBFPGtCI8G", "Filip" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MedicalStaffs",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
