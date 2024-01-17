using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class AddGameModel : PageModel
	{
		private readonly IVideoGameService videoGameService;
		private readonly IPersonService personService;

		public AddGameModel(IVideoGameService videoGameService, IPersonService personService)
		{
			this.videoGameService = videoGameService;
			this.personService = personService;
		}

		public void OnGet()
		{
			this.VideoGames = this.videoGameService.GetAll();
			this.Personnages = this.personService.GetAll();
		}

		public List<VideoGame>? VideoGames { get; set; }
		public List<PersonneAJouer>? Personnages { get; set; }
	}
}
