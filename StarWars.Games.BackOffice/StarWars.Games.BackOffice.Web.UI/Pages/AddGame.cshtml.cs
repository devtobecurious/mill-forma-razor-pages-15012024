using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class AddGameModel : PageModel
	{
		private readonly IVideoGameService videoGameService;
		private readonly IPersonService personService;
		private readonly IAmiService amisService;
		private readonly HttpClient client;

		public AddGameModel(IVideoGameService videoGameService, IPersonService personService, IAmiService amisService, HttpClient client)
		{
			this.videoGameService = videoGameService;
			this.personService = personService;
			this.amisService = amisService;
			this.client = client;
		}

		public async Task OnGet()
		{
			this.VideoGames = this.videoGameService.GetAll();
			this.Amis = this.amisService.GetAll();
			this.Personnages = await this.personService.GetAllAsync();
		}

		public List<VideoGame>? VideoGames { get; set; }
		public List<PersonneAJouer>? Personnages { get; set; }

		public List<Ami>? Amis { get; set; }
	}

}

internal class PeopleResponse
{
	public List<PersonneAJouer>? Results { get; set; }
}
