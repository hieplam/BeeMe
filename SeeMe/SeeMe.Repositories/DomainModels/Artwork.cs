namespace SeeMe.Repositories.DomainModels
{
    public class Artwork
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ArtworkUrl { get; set; }

        public virtual Artist Artist { get; set; }
    }
}