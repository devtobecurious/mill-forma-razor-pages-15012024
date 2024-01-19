using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using StarWars.BackOffice.Core.Models;
using StarWars.Games.BackOffice.Web.UI.App_Code.CustomSettings;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.Pages
{
    public class ListGameModel : PageModel
    {
        private List<Game>? _games;
        private readonly IGameService service;
        private readonly SearchSetting setting;

        public ListGameModel(IGameService service, IOptions<SearchSetting> options)
        {
            this.service = service;
            this.service = service;
            this.setting = options.Value;
        }

        public void OnGet()
        {
            this._games = this.service.GetAll(this.Filter ?? new Filter());
        }

        [BindProperty(SupportsGet = true)] // De base, le BindProperty remplit uniquement en requete post
        public Filter? Filter { get; set; }

        public List<Game>? Games { get => _games; }
        public List<Game>? GamesBis { get { return _games; } }

        public Dictionary<string, string> GameEtats = new Dictionary<string, string>()
        {
            { "Success", "Succès" },
            { "Failed", "Echec" }
        };
    }
}
