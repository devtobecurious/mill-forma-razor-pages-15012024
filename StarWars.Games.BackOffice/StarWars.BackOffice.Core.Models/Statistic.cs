namespace StarWars.BackOffice.Core.Models
{
	public class Statistic
	{
		#region Properties
		public int Annee { get; set; }

		public int Mois { get; set; }

		public List<Game> GameList { get; set; } = new List<Game>();
		#endregion
	}
}
