using StarWars.BackOffice.Core.Models;

namespace StarWars.Games.Core.Interfaces
{
	public interface IPersonService : IGetAll<PersonneAJouer>
	{
		Task<List<PersonneAJouer>> GetAllAsync();
	}
}
