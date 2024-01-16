using StarWars.BackOffice.Core.Models;

namespace StarWars.Games.Core.Interfaces
{
	public interface IStatisticService
	{
		List<Statistic> GetAll();
	}
}
