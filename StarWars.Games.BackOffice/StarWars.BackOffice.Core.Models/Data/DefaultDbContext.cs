﻿using Microsoft.EntityFrameworkCore;

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

		public DbSet<VideoGame> VideoGames { get; set; } // Je pourrai etre connecté à ma base de données et ramener la liste des videogames, crud

		// public DbSet<Game> Games { get; set; }
	}
}