using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lecture9PL.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdStudentGroup",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    IdStudentGroup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.IdStudentGroup);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdStudentGroup",
                table: "Students",
                column: "IdStudentGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGroups_IdStudentGroup",
                table: "Students",
                column: "IdStudentGroup",
                principalTable: "StudentGroups",
                principalColumn: "IdStudentGroup",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGroups_IdStudentGroup",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentGroups");

            migrationBuilder.DropIndex(
                name: "IX_Students_IdStudentGroup",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdStudentGroup",
                table: "Students");
        }
    }
}
