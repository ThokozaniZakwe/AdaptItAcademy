using Microsoft.EntityFrameworkCore.Migrations;

namespace AdaptItAcademy.DataAccess.Migrations
{
    public partial class DietaryRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Dietary_DietaryID",
                table: "Trainings");

            migrationBuilder.DropTable(
                name: "Dietary");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_DietaryID",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "DietaryID",
                table: "Trainings");

            migrationBuilder.AddColumn<int>(
                name: "Dietary",
                table: "Trainings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dietary",
                table: "Trainings");

            migrationBuilder.AddColumn<int>(
                name: "DietaryID",
                table: "Trainings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dietary",
                columns: table => new
                {
                    DietaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dietary", x => x.DietaryID);
                });

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
    }
}
