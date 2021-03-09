using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramDayActivity_Activity_ActivityId",
                table: "ProgramDayActivity");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "ProgramDayActivity",
                newName: "ActivityAttachmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramDayActivity_ActivityActivityAttachment_ActivityAttachmentId",
                table: "ProgramDayActivity",
                column: "ActivityAttachmentId",
                principalTable: "ActivityActivityAttachment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramDayActivity_ActivityActivityAttachment_ActivityAttachmentId",
                table: "ProgramDayActivity");

            migrationBuilder.RenameColumn(
                name: "ActivityAttachmentId",
                table: "ProgramDayActivity",
                newName: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramDayActivity_Activity_ActivityId",
                table: "ProgramDayActivity",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
