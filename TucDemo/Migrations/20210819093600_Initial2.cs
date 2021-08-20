using Microsoft.EntityFrameworkCore.Migrations;

namespace TucDemo.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "position",
                table: "player");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "player",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "player");

            migrationBuilder.AddColumn<int>(
                name: "position",
                table: "player",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
