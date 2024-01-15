using StarWars.BackOffice.Core.Models;

namespace StarWars.BackOffice.Core.Services
{
	public class StatisticService
	{
		public List<Statistic> GetAll()
		{
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
