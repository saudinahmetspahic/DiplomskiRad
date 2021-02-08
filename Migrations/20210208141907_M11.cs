using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateChat_Message_MessageId",
                table: "PrivateChat");

            migrationBuilder.DropIndex(
                name: "IX_PrivateChat_MessageId",
                table: "PrivateChat");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "PrivateChat");

            migrationBuilder.AddColumn<int>(
                name: "PrivateChatId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Message_PrivateChatId",
                table: "Message",
                column: "PrivateChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_PrivateChat_PrivateChatId",
                table: "Message",
                column: "PrivateChatId",
                principalTable: "PrivateChat",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_PrivateChat_PrivateChatId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_PrivateChatId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "PrivateChatId",
                table: "Message");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "PrivateChat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PrivateChat_MessageId",
                table: "PrivateChat",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateChat_Message_MessageId",
                table: "PrivateChat",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
