using StarWars.BackOffice.Core.Models;
using StarWars.BackOffice.Core.Models.Data;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class SqlServerDbContextGameService : IGameService
	{
		private readonly DefaultDbContext context;

		public SqlServerDbContextGameService(DefaultDbContext context)
		{
			this.context = context;
		}

		public void Add(Game item)
		{
			this.context.Games.Add(item);

			//this.context.Games.Remove(item);

			this.context.SaveChanges();
		}

		public List<Game> GetAll()
		{
			// this.context.Games.FromSqlRaw("dbo.maProcedureStokee", new { param1 = 1 }).ToList();

			return new List<Game>();
		}

		public List<Game> GetAll(Filter filter)
		{
			throw new NotImplementedException();
		}
	}
}
