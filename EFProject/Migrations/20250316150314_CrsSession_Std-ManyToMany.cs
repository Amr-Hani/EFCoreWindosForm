using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class CrsSession_StdManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseSessionAttendances",
                columns: table => new
                {
                    St_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrsSession_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessionAttendances", x => new { x.St_ID, x.CrsSession_ID });
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendances_CourseSessions_CrsSession_ID",
                        column: x => x.CrsSession_ID,
                        principalTable: "CourseSessions",
                        principalColumn: "CrsSession_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendances_Student_St_ID",
                        column: x => x.St_ID,
                        principalTable: "Student",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_CrsSession_ID",
                table: "CourseSessionAttendances",
                column: "CrsSession_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSessionAttendances");
        }
    }
}
