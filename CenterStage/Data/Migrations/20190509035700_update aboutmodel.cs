using Microsoft.EntityFrameworkCore.Migrations;

namespace CenterStage.Data.Migrations
{
    public partial class updateaboutmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudioName",
                table: "AboutModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudioName",
                table: "AboutModel",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
