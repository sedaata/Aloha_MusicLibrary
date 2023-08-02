using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Make sure to include this namespace if it's not already included.

namespace Aloha_MusicLibrary.Services
{
    public class ArtistService
    {
        private readonly MusicStoreContext _context;

        public ArtistService(MusicStoreContext context)
        {
            _context = context;
        }

        // Create a new artist
        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        // Retrieve all artists
        public List<Artist> GetAllArtists()
        {
            return _context.Artists.ToList();
        }

        // Retrieve an artist by ID
        public Artist GetArtistById(int artistId)
        {
            return _context.Artists.FirstOrDefault(a => a.Id == artistId);
        }

        // Update an artist's information
        public void UpdateArtist(Artist artist)
        {
            _context.Entry(artist).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete an artist by ID
        public void DeleteArtist(int artistId)
        {
            var artist = _context.Artists.Find(artistId);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
                _context.SaveChanges();
            }
        }
    }
}
