using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public abstract class BaseService<T> : IGetAll<T> where T : class
	{
		public abstract List<T> GetAll();
	}
}
