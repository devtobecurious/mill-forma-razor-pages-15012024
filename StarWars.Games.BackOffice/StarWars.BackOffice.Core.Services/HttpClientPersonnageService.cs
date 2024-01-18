using Newtonsoft.Json;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.BackOffice.Core.Services
{
	#region Classes internes
	internal class PeopleApi
	{
		public string Name { get; set; } = string.Empty;
	}

	internal class PeopleResultApi
	{
		public List<PeopleApi> Results { get; set; }
	}
	#endregion

	public class HttpClientPersonnageService : IPersonService
	{
		private readonly HttpClient client;

		public HttpClientPersonnageService(HttpClient client)
		{
			this.client = client;
		}

		//public async List<PersonneAJouer> GetAll()
		public List<PersonneAJouer>? GetAll()
		{
			return new List<PersonneAJouer>();
		}

		public async Task<List<PersonneAJouer>> GetAllAsync()
		{
			var response = await this.client.GetAsync("https://swapi.dev/api/people");
			var content = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<PeopleResultApi>(content);

			var list = new List<PersonneAJouer>();
			for (int i = 0; i < result?.Results.Count; i++)
			{
				list.Add(new PersonneAJouer()
				{
					Id = i,
					Surname = result?.Results[i].Name!
				});
			}

			return list;
		}
	}
}
