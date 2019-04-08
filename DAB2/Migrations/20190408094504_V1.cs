using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB2.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BinaryData = table.Column<int>(nullable: false),
                    GroupSignupLink = table.Column<string>(nullable: false),
                    AudioLink = table.Column<string>(nullable: false),
                    VideoLink = table.Column<string>(nullable: false),
                    ContentAreaId = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ContentId",
                table: "Courses",
                column: "ContentId",
                unique: true,
                filter: "[ContentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Content_ContentId",
                table: "Courses",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Content_ContentId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ContentId",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "ContentId",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
