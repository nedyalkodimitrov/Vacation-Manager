using Microsoft.EntityFrameworkCore.Migrations;

namespace VManager.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReasonForAbsence",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "LeaderId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "Approved",
                table: "Vacations",
                newName: "IsApproved");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsLeader",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "IsLeader",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Vacations",
                newName: "Approved");

            migrationBuilder.AddColumn<string>(
                name: "ReasonForAbsence",
                table: "Vacations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeaderId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
