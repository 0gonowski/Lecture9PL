using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lecture9PL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingOfStudentAndStudentGroupTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "IdStudentGroup", "Name" },
                values: new object[,]
                {
                    { 1, "Computer Science A" },
                    { 2, "Computer Science B" },
                    { 3, "Computer Science C" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "BirthDate", "Email", "FirstName", "IdStudentGroup", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@gmail.com", "John", 1, "Doe" },
                    { 2, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.doe@gmail.com", "Jane", 3, "Dose" },
                    { 3, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johne.dosse@gmail.com", "Johne", 3, "Dosse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "IdStudentGroup",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "IdStudentGroup",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "IdStudentGroup",
                keyValue: 3);
        }
    }
}
