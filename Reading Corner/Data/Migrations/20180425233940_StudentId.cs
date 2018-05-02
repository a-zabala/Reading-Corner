using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Reading_Corner.Data.Migrations
{
    public partial class StudentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingRecords_Students_StudentID",
                table: "ReadingRecords");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "ReadingRecords",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ReadingRecords_StudentID",
                table: "ReadingRecords",
                newName: "IX_ReadingRecords_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "ReadingRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingRecords_Students_StudentId",
                table: "ReadingRecords",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingRecords_Students_StudentId",
                table: "ReadingRecords");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "ReadingRecords",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_ReadingRecords_StudentId",
                table: "ReadingRecords",
                newName: "IX_ReadingRecords_StudentID");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "ReadingRecords",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingRecords_Students_StudentID",
                table: "ReadingRecords",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
