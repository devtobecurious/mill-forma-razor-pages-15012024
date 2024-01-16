using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class StatisticService : BaseService<Statistic>, IStatisticService
	{
		private readonly ICustomLogger logger;

		public StatisticService(ICustomLogger logger)
		{
			this.logger = logger;
		}

		public override List<Statistic> GetAll()
		{
			this.logger.Log("Get all appelée");

			var list = new List<Statistic>();
			list.Add(new Statistic()
			{
				Annee = 2020,
				Mois = 2,
				GameList = new List<Game>()
				{
					new Game() { Date = DateTime.Now, Etat = "Failed" },
					new Game() { Date = DateTime.Now, Etat = "Success" },
				}
			});
			list.Add(new Statistic()
			{
				Annee = 2024,
				Mois = 3,
				GameList = new List<Game>()
				{
					new Game() { Date = DateTime.Now, Etat = "Failed" },
					new Game() { Date = DateTime.Now, Etat = "Failed" },
				}
			});

			return list;
		}
	}
}
