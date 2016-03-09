using System.Collections.Generic;

namespace SeeMe.DomainModels
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string AvatarUrl { get; set; }

        public virtual IList<Artwork> Artworks { get; set; }
    }
}