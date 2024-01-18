using Microsoft.EntityFrameworkCore;
using StarWars.BackOffice.Core.Models.Data.EntityTypeConfigurations;

namespace StarWars.BackOffice.Core.Models.Data
{
	public class DefaultDbContext : DbContext // ORM ici
	{
		public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options) // <DefaultDbContext> si plusieurs db context dans mon program
		{
		}

		protected DefaultDbContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.Entity<VideoGame>().ToTable("VideoGame"); // Le nom de la table SQL est VideoGame
			//modelBuilder.Entity<VideoGame>().Property(item => item.Id).HasColumnName("Identifiant"); // le nom de la colonne en base est Identifiant
			modelBuilder.ApplyConfiguration(new VideoGameEntityTypeConfiguration());

			var nomTableSql = "Ami";
			modelBuilder.Entity<Ami>().ToTable(nomTableSql);
		}

		public DbSet<VideoGame> VideoGames { get; set; } // Je pourrai etre connecté à ma base de données et ramener la liste des videogames, crud
														 // Nom du dbset (de la property) = nom de la table

		public DbSet<Ami> Amis { get; set; }
		// public DbSet<Game> Games { get; set; }
	}
}
