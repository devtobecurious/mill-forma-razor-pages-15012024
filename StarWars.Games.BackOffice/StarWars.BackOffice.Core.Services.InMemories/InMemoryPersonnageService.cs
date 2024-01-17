using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services.InMemories
{
	public class InMemoryPersonnageService : IPersonService
	{
		public List<PersonneAJouer> GetAll()
		{
			return new List<PersonneAJouer>
			{
				new PersonneAJouer() { Id = 1, Surname = "Anakin" },
				new PersonneAJouer() { Id = 2, Surname = "Jar Jar" },
				new PersonneAJouer() { Id = 3, Surname = "Qui Gon" },
				new PersonneAJouer() { Id = 4, Surname = "Yoda" }
			};
		}
	}
}
