using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWars.BackOffice.Core.Models;
using StarWars.BackOffice.Core.Services;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class ListStatisticModel : PageModel
	{
		public void OnGet()
		{
			this.List = (new StatisticService()).GetAll();

			//foreach (var item in this.List)
			//{
			//	var games = item.GamesAsSuccess; // Lazy : �a ne s'ex�cute pas 
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
