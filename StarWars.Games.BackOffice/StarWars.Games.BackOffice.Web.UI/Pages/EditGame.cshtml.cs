using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class EditGameModel : PageModel
	{
		public void OnGet(int idGame, string title)
		{
		}

		//[BindProperty]
		//public int IdGame { get; set; }
	}
}
