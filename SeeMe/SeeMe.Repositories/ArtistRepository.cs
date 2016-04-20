using SeeMe.Repositories.DomainModels;
using SeeMe.Repositories.Interfaces;

namespace SeeMe.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>,IArtistRepository
    {
        public ArtistRepository(DataContext context) : base(context)
        {
        }
    }
}
