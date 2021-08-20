using Microsoft.EntityFrameworkCore.Migrations;

namespace TucDemo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DerseyNumber",
                table: "player",
                newName: "JerseyNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JerseyNumber",
                table: "player",
                newName: "DerseyNumber");
        }
    }
}
