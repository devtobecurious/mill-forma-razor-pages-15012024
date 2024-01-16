using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class ListGameModel : PageModel
	{
		private List<Game>? _games;
		private readonly IGameService service;

		public ListGameModel(IGameService service)
		{
			this.service = service;
			this.service = service;
		}

		public void OnGet()
		{
			this._games = this.service.GetAll();
		}

		public List<Game>? Games { get => _games; }
		public List<Game>? GamesBis { get { return _games; } }
	}
}
