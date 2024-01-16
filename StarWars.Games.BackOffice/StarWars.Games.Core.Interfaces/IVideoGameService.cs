using StarWars.BackOffice.Core.Models;

namespace StarWars.Games.Core.Interfaces
{
	public interface IVideoGameService : IGetOne<VideoGame>, IGetAll<VideoGame>
	{
	}
}
