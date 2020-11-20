using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseManagement.Migrations
{
    public partial class Finish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateAppointments");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "Courses",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "endTime",
                table: "Courses",
                newName: "endDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Courses",
                newName: "startTime");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Courses",
                newName: "endTime");

            migrationBuilder.CreateTable(
                name: "DateAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateAppointments", x => x.Id);
                });
        }
    }
}
