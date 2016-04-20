using SeeMe.Repositories.Interfaces;
using SeeMe.Services.Interfaces;

namespace SeeMe.Services
{
    public class ArtistService : IArtistService
    {
        private IArtistRepository _artistRepository;
        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }
    }
}
