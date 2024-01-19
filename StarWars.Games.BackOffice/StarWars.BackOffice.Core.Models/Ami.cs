using System.ComponentModel.DataAnnotations;

namespace StarWars.BackOffice.Core.Models
{
    public class Ami
    {
        public int Id { get; set; }

        public string Prenom { get; set; } = string.Empty;

        public DateTime DateNaissance { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }
    }
}
