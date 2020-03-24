using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore.ManyToMany
{
    public class ManyToManyContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumArtist> AlbumArtists { get; set; }

        public ManyToManyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlDatabaseString.ClassLibraryNetCore);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                        .Property(album => album.Name)
                        .HasMaxLength(20)
                        .IsRequired();

            modelBuilder.Entity<Artist>()
                        .Property(artist => artist.FirstName)
                        .HasMaxLength(15)
                        .IsRequired();


            modelBuilder.Entity<AlbumArtist>()
                        .HasKey(albumArtistLink => new { albumArtistLink.AlbumId, albumArtistLink.ArtistId });

            modelBuilder.Entity<AlbumArtist>()
                        .HasOne(albumArtistLink => albumArtistLink.Album)
                        .WithMany(album => album.AlbumArtists);

            modelBuilder.Entity<AlbumArtist>()
                        .HasOne(albumArtistLink => albumArtistLink.Artist)
                        .WithMany(artist => artist.AlbumArtists);
        }
    }
}