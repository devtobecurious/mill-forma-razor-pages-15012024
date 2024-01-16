using StarWars.Games.Core.Interfaces;

namespace FakeLoggerTest
{
	public class TestLogger : ICustomLogger
	{
		public void Log(string message)
		{
			throw new NotImplementedException();
		}
	}
}
