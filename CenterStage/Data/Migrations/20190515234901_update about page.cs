using Microsoft.EntityFrameworkCore.Migrations;

namespace CenterStage.Data.Migrations
{
    public partial class updateaboutpage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutModel",
                table: "AboutModel");

            migrationBuilder.RenameTable(
                name: "AboutModel",
                newName: "About");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "StudentInfo",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_About",
                table: "About",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_About",
                table: "About");

            migrationBuilder.RenameTable(
                name: "About",
                newName: "AboutModel");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "StudentInfo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutModel",
                table: "AboutModel",
                column: "ID");
        }
    }
}
