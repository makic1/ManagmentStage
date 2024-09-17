using StageManagment.Entities;

namespace StageManagment.Service
{
    public class ServiceArtist
    {
        private readonly DbContextStageManagment _context;

        public ServiceArtist(DbContextStageManagment context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all artist
        /// </summary>
        /// <returns>a list of Artist</returns>
        public List<Artist> GetAllArtists()
        {
            return _context.Artists.ToList();
        }

        /// <summary>
        /// Add a Artist
        /// </summary>
        /// <param name="artist"></param>
        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update a Artist
        /// </summary>
        /// <param name="artistToUpdate"></param>
        public void UpdateArtist(Artist artistToUpdate)
        {
            var artist = FindArtistById(artistToUpdate.ArtistId);

            if (artist is not null)
            {
                artist.ArtistId = artistToUpdate.ArtistId;
                artist.Name = artistToUpdate.Name;
                artist.ArtistCategorie = artistToUpdate.ArtistCategorie;

                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Remove a artist by id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveArtistById(int id)
        {
            _context.Artists.Remove(FindArtistById(id));
            _context.SaveChanges();
        }

        /// <summary>
        /// Find a Artist with Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Artist FindArtistById(int id)
        {
            return _context.Artists.Find(id);
        }

        /// <summary>
        /// Check of duplicate artist
        /// </summary>
        /// <param name="artist"></param>
        /// <returns>true or false</returns>
        public bool CheckForDuplicateArtist(Artist artist)
        {
            return _context.Artists.Any(a => a.Name == artist.Name && a.ArtistCategorie == artist.ArtistCategorie);
        }
    }
}
