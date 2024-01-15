namespace StarWars.BackOffice.Core.Models
{
	public class Game
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }

		public string Etat { get; set; } = string.Empty;
	}
}
