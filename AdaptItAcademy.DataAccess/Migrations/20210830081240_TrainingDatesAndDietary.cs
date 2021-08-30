using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdaptItAcademy.DataAccess.Migrations
{
    public partial class TrainingDatesAndDietary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dietary",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "TrainingDate",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "Dietary",
                columns: table => new
                {
                    DietaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dietary", x => x.DietaryID);
                    table.ForeignKey(
                        name: "FK_Dietary_Trainings_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Trainings",
                        principalColumn: "TrainingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingDate",
                columns: table => new
                {
                    TrainingDateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDate", x => x.TrainingDateID);
                    table.ForeignKey(
                        name: "FK_TrainingDate_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dietary_TrainingID",
                table: "Dietary",
                column: "TrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDate_CourseID",
                table: "TrainingDate",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dietary");

            migrationBuilder.DropTable(
                name: "TrainingDate");

            migrationBuilder.AddColumn<string>(
                name: "Dietary",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TrainingDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
