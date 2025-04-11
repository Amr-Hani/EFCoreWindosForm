using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class InsDepartmentOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Dept_id",
                table: "Instructors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_id",
                table: "Instructors",
                column: "Dept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors",
                column: "Dept_id",
                principalTable: "Departments",
                principalColumn: "Dept_Id",
                onDelete:ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_id",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Dept_id",
                table: "Instructors");
        }
    }
}
