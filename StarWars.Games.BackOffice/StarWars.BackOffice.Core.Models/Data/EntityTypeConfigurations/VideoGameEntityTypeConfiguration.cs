using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarWars.BackOffice.Core.Models.Data.EntityTypeConfigurations
{
    public class VideoGameEntityTypeConfiguration : IEntityTypeConfiguration<VideoGame>
    {
        public void Configure(EntityTypeBuilder<VideoGame> builder)
        {
            builder.ToTable("VideoGame"); // Le nom de la table SQL est VideoGame
            builder.Property(item => item.Id).HasColumnName("Identifiant"); // le nom de la colonne en base est Identifiant
        }
    }
}
