using SeeMe.Repositories.DomainModels;
using SeeMe.Repositories.Interfaces;

namespace SeeMe.Repositories
{
    public class ArtworkRepository : BaseRepository<Artwork>, IArtworkRepository
    {
        public ArtworkRepository(DataContext context) : base(context)
        {
        }
    }
}
