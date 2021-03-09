using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time_Of_Activity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupChat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatingTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_User_SenderId",
                        column: x => x.SenderId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PrivateChat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User1Id = table.Column<int>(type: "int", nullable: false),
                    User2Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateChat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivateChat_User_User1Id",
                        column: x => x.User1Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PrivateChat_User_User2Id",
                        column: x => x.User2Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Program_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProgramDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDay = table.Column<int>(type: "int", nullable: false),
                    Date_Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOver = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfAttachment = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceToVisit = table.Column<double>(type: "float", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityAttachment_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GroupChatParticipants",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChatParticipants", x => new { x.GroupChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_GroupChatParticipants_GroupChat_GroupChatId",
                        column: x => x.GroupChatId,
                        principalTable: "GroupChat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GroupChatParticipants_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GroupChatMessage",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    GroupChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChatMessage", x => new { x.GroupChatId, x.MessageId });
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_GroupChat_GroupChatId",
                        column: x => x.GroupChatId,
                        principalTable: "GroupChat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_Message_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Message",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PrivateChatMessage",
                columns: table => new
                {
                    PrivateChatId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateChatMessage", x => new { x.PrivateChatId, x.MessageId });
                    table.ForeignKey(
                        name: "FK_PrivateChatMessage_Message_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Message",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PrivateChatMessage_PrivateChat_PrivateChatId",
                        column: x => x.PrivateChatId,
                        principalTable: "PrivateChat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProgramDayActivity",
                columns: table => new
                {
                    ProgramDayId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDayActivity", x => new { x.ActivityId, x.ProgramDayId });
                    table.ForeignKey(
                        name: "FK_ProgramDayActivity_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProgramDayActivity_ProgramDay_ProgramDayId",
                        column: x => x.ProgramDayId,
                        principalTable: "ProgramDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProgramProgramDay",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    ProgramDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramProgramDay", x => new { x.ProgramId, x.ProgramDayId });
                    table.ForeignKey(
                        name: "FK_ProgramProgramDay_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProgramProgramDay_ProgramDay_ProgramDayId",
                        column: x => x.ProgramDayId,
                        principalTable: "ProgramDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ActivityActivityAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivityAttachmentId = table.Column<int>(type: "int", nullable: false),
                    PlannedStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedFinish = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityActivityAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityActivityAttachment_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ActivityActivityAttachment_ActivityAttachment_ActivityAttachmentId",
                        column: x => x.ActivityAttachmentId,
                        principalTable: "ActivityAttachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActivityAttachment_ActivityAttachmentId",
                table: "ActivityActivityAttachment",
                column: "ActivityAttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActivityAttachment_ActivityId",
                table: "ActivityActivityAttachment",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttachment_ActivityId",
                table: "ActivityAttachment",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_MessageId",
                table: "GroupChatMessage",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatParticipants_UserId",
                table: "GroupChatParticipants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateChat_User1Id",
                table: "PrivateChat",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateChat_User2Id",
                table: "PrivateChat",
                column: "User2Id");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateChatMessage_MessageId",
                table: "PrivateChatMessage",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_CreatorId",
                table: "Program",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramDayActivity_ProgramDayId",
                table: "ProgramDayActivity",
                column: "ProgramDayId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramProgramDay_ProgramDayId",
                table: "ProgramProgramDay",
                column: "ProgramDayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityActivityAttachment");

            migrationBuilder.DropTable(
                name: "GroupChatMessage");

            migrationBuilder.DropTable(
                name: "GroupChatParticipants");

            migrationBuilder.DropTable(
                name: "PrivateChatMessage");

            migrationBuilder.DropTable(
                name: "ProgramDayActivity");

            migrationBuilder.DropTable(
                name: "ProgramProgramDay");

            migrationBuilder.DropTable(
                name: "ActivityAttachment");

            migrationBuilder.DropTable(
                name: "GroupChat");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "PrivateChat");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "ProgramDay");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "User");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "User",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
