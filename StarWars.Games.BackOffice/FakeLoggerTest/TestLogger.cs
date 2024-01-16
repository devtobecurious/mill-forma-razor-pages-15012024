using StarWars.Games.Core.Interfaces;
using System.Diagnostics;

namespace FakeLoggerTest
{
	public class TestLogger : ICustomLogger
	{
		public void Log(string message)
		{
			Debug.WriteLine(message);
		}
	}
}
