using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB2.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignment_Assignments_AssignmentId",
                table: "CourseAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignment_Courses_CourseId",
                table: "CourseAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseAssignment",
                table: "CourseAssignment");

            migrationBuilder.RenameTable(
                name: "CourseAssignment",
                newName: "CourseAssignments");

            migrationBuilder.RenameIndex(
                name: "IX_CourseAssignment_AssignmentId",
                table: "CourseAssignments",
                newName: "IX_CourseAssignments_AssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseAssignments",
                table: "CourseAssignments",
                columns: new[] { "CourseId", "AssignmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignments_Assignments_AssignmentId",
                table: "CourseAssignments",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignments_Courses_CourseId",
                table: "CourseAssignments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignments_Assignments_AssignmentId",
                table: "CourseAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignments_Courses_CourseId",
                table: "CourseAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseAssignments",
                table: "CourseAssignments");

            migrationBuilder.RenameTable(
                name: "CourseAssignments",
                newName: "CourseAssignment");

            migrationBuilder.RenameIndex(
                name: "IX_CourseAssignments_AssignmentId",
                table: "CourseAssignment",
                newName: "IX_CourseAssignment_AssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseAssignment",
                table: "CourseAssignment",
                columns: new[] { "CourseId", "AssignmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignment_Assignments_AssignmentId",
                table: "CourseAssignment",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignment_Courses_CourseId",
                table: "CourseAssignment",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
