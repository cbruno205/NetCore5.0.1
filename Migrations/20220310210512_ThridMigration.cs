using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class ThridMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "user",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "user",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Person",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "user",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "user",
                newName: "LastName");
        }
    }
}
