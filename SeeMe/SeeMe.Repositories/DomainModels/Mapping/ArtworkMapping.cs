using System.Data.Entity.ModelConfiguration;

namespace SeeMe.Repositories.DomainModels.Mapping
{
    public class ArtworkMapping : EntityTypeConfiguration<Artwork>
    {
        public ArtworkMapping()
        {
            Property(x => x.ArtworkUrl).IsRequired();
            Property(x => x.Title).IsRequired();
            HasRequired(x=>x.Artist).WithMany(x=>x.Artworks).HasForeignKey(x=>x.ArtistId).WillCascadeOnDelete();
        }
    }
}