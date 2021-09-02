using Microsoft.EntityFrameworkCore.Migrations;

namespace AdaptItAcademy.DataAccess.Migrations
{
    public partial class UnlinkCourseToTraining : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Courses_CourseID",
                table: "Trainings");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_CourseID",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Trainings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Trainings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_CourseID",
                table: "Trainings",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Courses_CourseID",
                table: "Trainings",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
