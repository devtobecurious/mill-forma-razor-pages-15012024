using System.ComponentModel.DataAnnotations;

namespace StarWars.BackOffice.Core.Models
{
	public class Wookiee
	{
		[StringLength(3, ErrorMessage = "Longueur max de 3 !")]
		public string Prenom { get; set; } = string.Empty;
		public string? Nom { get; set; }

		[DataType(DataType.EmailAddress)]
		public string Email { get; set; } = string.Empty;

		[Range(7, 77)]
		public int? Age { get; set; }
	}
}
