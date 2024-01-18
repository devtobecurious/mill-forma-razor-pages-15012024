using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class InMemoryGameService : BaseService<Game>, IGameService
	{
		private static List<Game> __games = new List<Game>()
		{
			{ new Game { Id = 1, Date =  DateTime.Now, Etat = "Success", VideoGameId = null } },
			{ new Game { Id = 2, Date =  DateTime.Now.AddMonths(-1), Etat = "Failed", VideoGameId = 1 } },
		};

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
			__games.ForEach(item =>
			{
				item.VideoGame = this.videoGameService.GetOne(item.VideoGameId);
			});

			return __games;
		}

		public List<Game> GetAll(Filter filter)
		{
			var query = from item in __games
						select item;

			if (!string.IsNullOrEmpty(filter.Etat))
			{
				query = query.Where(item => item.Etat.ToLower() == filter.Etat.ToLower());
			}

			return query.OrderBy(item => item.Date).ToList();
		}
		#endregion
	}
}
