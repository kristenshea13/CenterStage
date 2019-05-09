using Microsoft.EntityFrameworkCore.Migrations;

namespace CenterStage.Data.Migrations
{
    public partial class userlockdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "StudentInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "StudentInfo");
        }
    }
}
