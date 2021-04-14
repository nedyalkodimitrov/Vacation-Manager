using Microsoft.EntityFrameworkCore.Migrations;

namespace VManager.Data.Migrations
{
    public partial class hi4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AspUser",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AspUser",
                table: "Users");
        }
    }
}
