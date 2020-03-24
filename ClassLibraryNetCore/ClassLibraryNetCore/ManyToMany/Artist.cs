using System.Collections.Generic;

namespace ClassLibraryNetCore.ManyToMany
{
    public class Artist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<AlbumArtist> AlbumArtists { get; set; }
        public Artist()
        {
            AlbumArtists = new List<AlbumArtist>();
        }

    }
}
