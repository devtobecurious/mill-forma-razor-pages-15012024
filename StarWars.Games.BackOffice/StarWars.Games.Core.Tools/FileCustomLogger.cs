using StarWars.Games.Core.Interfaces;
using System.Diagnostics;

namespace StarWars.Games.Core.Tools
{
	public class FileCustomLogger : ICustomLogger
	{
		public void Log(string message)
		{
			Debug.WriteLine(message);
			// File.WriteAllText("UnCheminDonne", message);
		}
	}
}
