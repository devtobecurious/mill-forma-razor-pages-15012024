using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class AddGameModel : PageModel
	{
		private readonly IVideoGameService videoGameService;

		public AddGameModel(IVideoGameService videoGameService)
		{
			this.videoGameService = videoGameService;
		}

		public void OnGet()
		{
			this.VideoGames = this.videoGameService.GetAll();
		}

		public List<VideoGame>? VideoGames { get; set; }
	}
}
