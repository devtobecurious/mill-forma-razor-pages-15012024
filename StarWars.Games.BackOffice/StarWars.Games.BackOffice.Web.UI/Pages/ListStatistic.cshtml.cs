using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class ListStatisticModel : PageModel
	{
		private readonly ICustomLogger logger;
		private readonly IStatisticService service;

		public ListStatisticModel(ICustomLogger logger, IStatisticService service)
		{
			this.logger = logger;
			this.service = service;
		}

		public void OnGet()
		{
			this.List = this.service.GetAll();

			//foreach (var item in this.List)
			//{
			//	var games = item.GamesAsSuccess; // Lazy : ça ne s'exécute pas 
			//									 //var result = games.ToList();
			//	foreach (var game in games.Where(item => item.Id == 1))
			//	{

			//	}
			//}
			//this.List = new List<Statistic>();
			//this.List.Add(new Statistic());
		}

		public List<Statistic>? List { get; set; }
	}
}
