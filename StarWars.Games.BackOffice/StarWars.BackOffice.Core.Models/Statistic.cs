namespace StarWars.BackOffice.Core.Models
{
	public class Statistic
	{
		#region Properties
		public int Annee { get; set; }

		public int Mois { get; set; }

		public List<Game> GameList { get; set; } = new List<Game>();

		public IEnumerable<Game> GamesAsSuccess => this.GameList.Where(item => item.Etat == "Success"); // Mieux renvoyer dès que vous le vous pouvez un IEnumerable
		public IEnumerable<Game> GamesAsFailed => this.GameList.Where(item => item.Etat == "Failed");
		#endregion
	}
}
