using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupChatId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupChatId",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsGroupMessage",
                table: "Message",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "GroupChat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatingTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChat", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_GroupChatId",
                table: "User",
                column: "GroupChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_GroupChatId",
                table: "Message",
                column: "GroupChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_GroupChat_GroupChatId",
                table: "Message",
                column: "GroupChatId",
                principalTable: "GroupChat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_GroupChat_GroupChatId",
                table: "User",
                column: "GroupChatId",
                principalTable: "GroupChat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_GroupChat_GroupChatId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_User_GroupChat_GroupChatId",
                table: "User");

            migrationBuilder.DropTable(
                name: "GroupChat");

            migrationBuilder.DropIndex(
                name: "IX_User_GroupChatId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Message_GroupChatId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "GroupChatId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GroupChatId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "IsGroupMessage",
                table: "Message");
        }
    }
}
