using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class InsDepartmentMangOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Manger_id",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Manger_id",
                table: "Departments",
                column: "Manger_id",
                unique: true,
                filter: "[Manger_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Manger_id",
                table: "Departments",
                column: "Manger_id",
                principalTable: "Instructors",
                principalColumn: "Ins_Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Manger_id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Manger_id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Manger_id",
                table: "Departments");
        }
    }
}
