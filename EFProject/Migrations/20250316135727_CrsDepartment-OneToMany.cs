using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class CrsDepartmentOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Dept_Id",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dept_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dept_Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Dept_Id",
                table: "Courses",
                column: "Dept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id"
                ,onDelete:ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Dept_Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Dept_Id",
                table: "Courses");
        }
    }
}
