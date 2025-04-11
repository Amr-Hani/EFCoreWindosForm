using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class Std_CrsManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    St_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.St_Id);
                });

            migrationBuilder.CreateTable(
                name: "CousreStudents",
                columns: table => new
                {
                    CourseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    St_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CousreStudents", x => new { x.St_ID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_CousreStudents_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CousreStudents_Student_St_ID",
                        column: x => x.St_ID,
                        principalTable: "Student",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CousreStudents_CourseID",
                table: "CousreStudents",
                column: "CourseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CousreStudents");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
