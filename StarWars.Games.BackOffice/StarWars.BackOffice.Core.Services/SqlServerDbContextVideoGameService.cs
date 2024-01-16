using StarWars.BackOffice.Core.Models;
using StarWars.BackOffice.Core.Models.Data;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class SqlServerDbContextVideoGameService : IVideoGameService
	{
		private readonly DefaultDbContext context;

		public SqlServerDbContextVideoGameService(DefaultDbContext context)
		{
			this.context = context;
		}

		public List<VideoGame> GetAll()
		{
			var query = from videoGame in context.VideoGames
						where videoGame.Name != ""
						select videoGame;

			//return this.context.VideoGames.ToList();
			// return query.ToList();


			return this.context.VideoGames
								.Where(item => item.Name != "")
								.Select(item => item) // A en parler
								.Take(100) // perf à parler
								.ToList(); // c'est le ToList qui lance la requête SQL !! 
		}

		public VideoGame GetOne(int? id)
		{
			throw new NotImplementedException();
		}
	}
}
