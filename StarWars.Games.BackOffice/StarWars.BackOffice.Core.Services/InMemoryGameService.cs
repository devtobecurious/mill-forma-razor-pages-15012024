using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class InMemoryGameService : BaseService<Game>, IGameService
	{
		private readonly IVideoGameService videoGameService;

		#region Constructors
		public InMemoryGameService(IVideoGameService videoGameService)
		{
			this.videoGameService = videoGameService;
		}
		#endregion

		#region Public methods
		public override List<Game> GetAll()
		{
			// Ca vient de la bdd
			List<Game> games = new List<Game>()
			{
				{ new Game { Id = 1, Date =  DateTime.Now, Etat = "Success", VideoGameId = null } },
				{ new Game { Id = 2, Date =  DateTime.Now.AddMonths(-1), Etat = "Failed", VideoGameId = 1 } },
			};

			games.ForEach(item =>
			{
				item.VideoGame = this.videoGameService.GetOne(item.VideoGameId);
			});

			return games;
		}
		#endregion
	}
}
