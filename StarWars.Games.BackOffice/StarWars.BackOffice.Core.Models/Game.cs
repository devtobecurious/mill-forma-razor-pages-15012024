using System.ComponentModel.DataAnnotations.Schema;

namespace StarWars.BackOffice.Core.Models
{
	public class Game
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }

		public string Etat { get; set; } = string.Empty;

		public int? VideoGameId { get; set; }

		public VideoGame? VideoGame { get; set; }

		[NotMapped]
		public List<Ami> Amis { get; set; } = new List<Ami>();
	}
}
