using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
	[BindProperties]
	public class DecouverteFormulaireModel : PageModel
	{
		public void OnGet()
		{
		}

		//public void OnPost()
		//{
		//	var valeurSaisie = this.Request.Form["prenom"];
		//}

		//public void OnPost(string prenom, string nom)
		//{
		//}

		//public void OnPost(Wookiee toto)
		//{
		//}

		public void OnPost()
		{
		}

		// Possibilité par property
		//[BindProperty]
		//public string Prenom { get; set; } = "";

		//[BindProperty]
		//public string Nom { get; set; } = "";


		public string Prenom { get; set; } = "";


		public string Nom { get; set; } = "";

		public int Pagination { get; set; }
	}

	public class Toto
	{
		public string? Prenom { get; set; }
		public string? Nom { get; set; }

		public int Age { get; set; }
	}

	public class Wookiee
	{
		public string? Prenom { get; set; }
		public string? Nom { get; set; }

		public int Age { get; set; }
	}
}

