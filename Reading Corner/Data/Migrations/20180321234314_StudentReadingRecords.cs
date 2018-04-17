using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Reading_Corner.Data.Migrations
{
    public partial class StudentReadingRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "ReadingRecords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReadingRecords_StudentID",
                table: "ReadingRecords",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingRecords_Students_StudentID",
                table: "ReadingRecords",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingRecords_Students_StudentID",
                table: "ReadingRecords");

            migrationBuilder.DropIndex(
                name: "IX_ReadingRecords_StudentID",
                table: "ReadingRecords");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "ReadingRecords");
        }
    }
}
