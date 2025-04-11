using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class addTableStudentInDBContextAndRemoveCourseStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessionAttendances_Student_St_ID",
                table: "CourseSessionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CousreStudents_Courses_CourseID",
                table: "CousreStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_CousreStudents_Student_St_ID",
                table: "CousreStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CousreStudents",
                table: "CousreStudents");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "CousreStudents",
                newName: "CousreStudent");

            migrationBuilder.RenameIndex(
                name: "IX_CousreStudents_CourseID",
                table: "CousreStudent",
                newName: "IX_CousreStudent_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "St_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CousreStudent",
                table: "CousreStudent",
                columns: new[] { "St_ID", "CourseID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_Students_St_ID",
                table: "CourseSessionAttendances",
                column: "St_ID",
                principalTable: "Students",
                principalColumn: "St_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CousreStudent_Courses_CourseID",
                table: "CousreStudent",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Crs_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CousreStudent_Students_St_ID",
                table: "CousreStudent",
                column: "St_ID",
                principalTable: "Students",
                principalColumn: "St_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessionAttendances_Students_St_ID",
                table: "CourseSessionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CousreStudent_Courses_CourseID",
                table: "CousreStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CousreStudent_Students_St_ID",
                table: "CousreStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CousreStudent",
                table: "CousreStudent");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "CousreStudent",
                newName: "CousreStudents");

            migrationBuilder.RenameIndex(
                name: "IX_CousreStudent_CourseID",
                table: "CousreStudents",
                newName: "IX_CousreStudents_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "St_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CousreStudents",
                table: "CousreStudents",
                columns: new[] { "St_ID", "CourseID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_Student_St_ID",
                table: "CourseSessionAttendances",
                column: "St_ID",
                principalTable: "Student",
                principalColumn: "St_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CousreStudents_Courses_CourseID",
                table: "CousreStudents",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Crs_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CousreStudents_Student_St_ID",
                table: "CousreStudents",
                column: "St_ID",
                principalTable: "Student",
                principalColumn: "St_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
