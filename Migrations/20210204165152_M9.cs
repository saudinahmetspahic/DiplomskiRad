using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityAttachment_Activity_ActivityId",
                table: "ActivityAttachment");

            migrationBuilder.DropIndex(
                name: "IX_ActivityAttachment_ActivityId",
                table: "ActivityAttachment");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "ActivityAttachment");

            migrationBuilder.DropColumn(
                name: "PlannedFinish",
                table: "ActivityAttachment");

            migrationBuilder.DropColumn(
                name: "PlannedStart",
                table: "ActivityAttachment");

            migrationBuilder.CreateTable(
                name: "ActivityActivityAttachment",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivityAttachmentId = table.Column<int>(type: "int", nullable: false),
                    PlannedStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedFinish = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityActivityAttachment", x => new { x.ActivityId, x.ActivityAttachmentId });
                    table.ForeignKey(
                        name: "FK_ActivityActivityAttachment_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityActivityAttachment_ActivityAttachment_ActivityAttachmentId",
                        column: x => x.ActivityAttachmentId,
                        principalTable: "ActivityAttachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActivityAttachment_ActivityAttachmentId",
                table: "ActivityActivityAttachment",
                column: "ActivityAttachmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityActivityAttachment");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "ActivityAttachment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedFinish",
                table: "ActivityAttachment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedStart",
                table: "ActivityAttachment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttachment_ActivityId",
                table: "ActivityAttachment",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityAttachment_Activity_ActivityId",
                table: "ActivityAttachment",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
