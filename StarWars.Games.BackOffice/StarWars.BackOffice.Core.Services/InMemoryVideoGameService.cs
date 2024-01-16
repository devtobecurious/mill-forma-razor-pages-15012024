using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class InMemoryVideoGameService : IVideoGameService
	{
		private static readonly List<VideoGame> __videoGames = new List<VideoGame>()
		{
			new VideoGame() { Id = 1, Name = "God of war" },
			new VideoGame() { Id = 2, Name = "Horizon forbiden" },
			new VideoGame() { Id = 3, Name = "Red redemption" }
		};

		public List<VideoGame> GetAll()
		{
			throw new NotImplementedException();
		}

		public VideoGame GetOne(int? id)
		{
			return __videoGames.First(x => x.Id == id);
		}
	}
}
