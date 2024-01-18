namespace StarWars.Games.Core.Interfaces
{
	public interface IGetAll<T> where T : class
	{
		List<T> GetAll();
	}

	public interface IGetAllWithFilters<T> where T : class
	{
		List<T> GetAll(Filter filter);
	}

	#region DTOs
	public class Filter
	{
		public string Etat { get; set; } = string.Empty;
	}
	#endregion
}
