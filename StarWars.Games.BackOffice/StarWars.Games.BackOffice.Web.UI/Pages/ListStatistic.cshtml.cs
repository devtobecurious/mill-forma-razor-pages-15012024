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
			//this.List = new List<Statistic>();
			//this.List.Add(new Statistic());
		}

		public List<Statistic>? List { get; set; }
	}
}
