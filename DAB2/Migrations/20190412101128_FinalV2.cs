using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB2.Migrations
{
    public partial class FinalV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupAssignments_Teachers_TeacherId",
                table: "GroupAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "GroupAssignments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_GroupAssignments_Teachers_TeacherId",
                table: "GroupAssignments",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupAssignments_Teachers_TeacherId",
                table: "GroupAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "GroupAssignments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupAssignments_Teachers_TeacherId",
                table: "GroupAssignments",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
