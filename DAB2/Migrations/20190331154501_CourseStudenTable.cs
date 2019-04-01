using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB2.Migrations
{
    public partial class CourseStudenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    AUID = table.Column<string>(nullable: true),
                    IsCoursePassed = table.Column<bool>(nullable: false),
                    IsCourseActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => new { x.StudentID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_CourseID",
                table: "CourseStudents",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudents");
        }
    }
}
