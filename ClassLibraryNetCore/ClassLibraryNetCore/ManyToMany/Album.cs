using System;
using System.Collections.Generic;

namespace ClassLibraryNetCore.ManyToMany
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public IList<AlbumArtist> AlbumArtists { get; set; }

        public Album()
        {
            AlbumArtists = new List<AlbumArtist>();
        }

    }
}
