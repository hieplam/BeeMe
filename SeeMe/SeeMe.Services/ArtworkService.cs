using SeeMe.Repositories.Interfaces;
using SeeMe.Services.Interfaces;

namespace SeeMe.Services
{
    public class ArtworkService : IArtworkService
    {
        private IArtworkRepository _artworkRepository;
        public ArtworkService(IArtworkRepository artworkRepository1)
        {
            _artworkRepository = artworkRepository1;
        }
    }
}
