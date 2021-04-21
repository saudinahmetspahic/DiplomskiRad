using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program_User_ApproverId",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_ApproverId",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "ApproverId",
                table: "Program");

            migrationBuilder.RenameColumn(
                name: "ProgramStatus",
                table: "Program",
                newName: "ProgramState");

            migrationBuilder.RenameColumn(
                name: "ApprovedDate",
                table: "Program",
                newName: "DateStateChanged");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAccessChanged",
                table: "Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAccessChanged",
                table: "Program");

            migrationBuilder.RenameColumn(
                name: "ProgramState",
                table: "Program",
                newName: "ProgramStatus");

            migrationBuilder.RenameColumn(
                name: "DateStateChanged",
                table: "Program",
                newName: "ApprovedDate");

            migrationBuilder.AddColumn<int>(
                name: "ApproverId",
                table: "Program",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Program_ApproverId",
                table: "Program",
                column: "ApproverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Program_User_ApproverId",
                table: "Program",
                column: "ApproverId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
