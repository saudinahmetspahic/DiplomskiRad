using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time_Of_Activity",
                table: "Activity");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Activity");

            migrationBuilder.AddColumn<int>(
                name: "Time_Of_Activity",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
