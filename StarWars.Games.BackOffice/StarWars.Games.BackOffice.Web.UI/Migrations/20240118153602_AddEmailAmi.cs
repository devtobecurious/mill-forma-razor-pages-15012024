using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarWars.Games.BackOffice.Web.UI.Migrations
{
    public partial class AddEmailAmi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Ami",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Ami");
        }
    }
}
