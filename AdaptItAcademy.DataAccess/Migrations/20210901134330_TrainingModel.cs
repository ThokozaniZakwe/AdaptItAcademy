using Microsoft.EntityFrameworkCore.Migrations;

namespace AdaptItAcademy.DataAccess.Migrations
{
    public partial class TrainingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dietary_Trainings_TrainingID",
                table: "Dietary");

            migrationBuilder.DropIndex(
                name: "IX_Dietary_TrainingID",
                table: "Dietary");

            migrationBuilder.DropColumn(
                name: "TrainingID",
                table: "Dietary");

            migrationBuilder.AddColumn<int>(
                name: "DietaryID",
                table: "Trainings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_DietaryID",
                table: "Trainings",
                column: "DietaryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Dietary_DietaryID",
                table: "Trainings",
                column: "DietaryID",
                principalTable: "Dietary",
                principalColumn: "DietaryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Dietary_DietaryID",
                table: "Trainings");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_DietaryID",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "DietaryID",
                table: "Trainings");

            migrationBuilder.AddColumn<int>(
                name: "TrainingID",
                table: "Dietary",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dietary_TrainingID",
                table: "Dietary",
                column: "TrainingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dietary_Trainings_TrainingID",
                table: "Dietary",
                column: "TrainingID",
                principalTable: "Trainings",
                principalColumn: "TrainingID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
