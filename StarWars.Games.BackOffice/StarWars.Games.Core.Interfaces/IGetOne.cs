namespace StarWars.Games.Core.Interfaces
{
	public interface IGetOne<T> where T : class
	{
		T GetOne(int? id);
	}
}
