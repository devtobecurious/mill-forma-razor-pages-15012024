using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarWars.Games.BackOffice.Web.UI.Migrations
{
	public partial class InitDb : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Ami",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Ami", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "VideoGame",
				columns: table => new
				{
					Identifiant = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_VideoGame", x => x.Identifiant);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Ami");

			migrationBuilder.DropTable(
				name: "VideoGame");
		}
	}
}
