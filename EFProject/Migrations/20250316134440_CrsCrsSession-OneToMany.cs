using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class CrsCrsSessionOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Crs_Id",
                table: "CourseSessions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_Crs_Id",
                table: "CourseSessions",
                column: "Crs_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Courses_Crs_Id",
                table: "CourseSessions",
                column: "Crs_Id",
                principalTable: "Courses",
                principalColumn: "Crs_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSessions_Courses_Crs_Id",
                table: "CourseSessions");

            migrationBuilder.DropIndex(
                name: "IX_CourseSessions_Crs_Id",
                table: "CourseSessions");

            migrationBuilder.DropColumn(
                name: "Crs_Id",
                table: "CourseSessions");
        }
    }
}
