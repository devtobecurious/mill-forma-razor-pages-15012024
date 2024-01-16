namespace StarWars.Games.Core.Interfaces
{
	public interface ICustomLogger
	{
		/// <summary>
		/// Log to file, or console ...
		/// </summary>
		/// <param name="message"></param>
		void Log(string message);
	}
}
