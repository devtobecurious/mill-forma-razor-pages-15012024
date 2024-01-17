using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	public class HttpClientPersonnageService : IPersonService
	{
		private readonly HttpClient client;

		public HttpClientPersonnageService(HttpClient client)
		{
			this.client = client;
		}

		public async List<PersonneAJouer> GetAll()
		{
			var result = await this.client.GetAsync("swapi");
		}
	}
}
