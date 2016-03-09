namespace SeeMe.DomainModels
{
    public class Artwork
    {
        public string Id { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public virtual Artist Artist { get; set; }
    }
}