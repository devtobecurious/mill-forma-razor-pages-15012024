using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class InMemoryGameService : BaseService<Game>, IGameService
	{
		#region Public methods
		public override List<Game> GetAll()
		{
			List<Game> games = new List<Game>()
			{
				{ new Game { Id = 1, Date =  DateTime.Now, Etat = "Success" } },
				{ new Game { Id = 2, Date =  DateTime.Now.AddMonths(-1), Etat = "Failed" } },
			};

			return games;
		}
		#endregion
	}
}
