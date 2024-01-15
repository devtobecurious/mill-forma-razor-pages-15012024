using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class ListGameModel : PageModel
	{
		private readonly List<Game> _games = new List<Game>()
		{
			{ new Game { Id = 1, Date =  DateTime.Now, Etat = "Success" } },
			{ new Game { Id = 2, Date =  DateTime.Now.AddMonths(-1), Etat = "Failed" } },
		};

		public void OnGet()
		{

		}

		public List<Game> Games { get => _games; }
		public List<Game> GamesBis { get { return _games; } }
	}
}
