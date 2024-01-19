using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public IActionResult OnGet()
		{
			HttpContext.Session.SetString("Id", "1");

			//return this.Redirect("ListStatistic");
			//return this.RedirectToPage("ListStatistic");

			return this.RedirectToPage("EditGame", new { idGame = 1, title = "test" });
		}
	}
}
