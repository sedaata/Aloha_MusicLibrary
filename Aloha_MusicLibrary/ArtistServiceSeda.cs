using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace Aloha_MusicLibrary.Services
{
    p
}
class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Song
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Artist Artist { get; set; }
}

class Playlist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Song> Songs { get; set; }
}

class ArtistService
{
    private List<Artist> artists = new List<Artist>();

    public List<Artist> GetAllArtists()
    {
        return artists;
    }

    ublic class ArtistService
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

class SongService
{
    private List<Song> songs = new List<Song>();

    public List<Song> GetAllSongs()
    {
        return songs;
    }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public Song GetSongById(int id)
    {
        return songs.FirstOrDefault(song => song.Id == id);
    }

    public void UpdateSong(Song updatedSong)
    {
        Song existingSong = songs.FirstOrDefault(song => song.Id == updatedSong.Id);
        if (existingSong != null)
        {
            existingSong.Name = updatedSong.Name;
            existingSong.Artist = updatedSong.Artist;
        }
    }

    public void DeleteSong(int id)
    {
        Song songToDelete = songs.FirstOrDefault(song => song.Id == id);
        if (songToDelete != null)
        {
            songs.Remove(songToDelete);
        }
    }
}

class PlaylistService
{
    private List<Playlist> playlists = new List<Playlist>();

    public List<Playlist> GetAllPlaylists()
    {
        return playlists;
    }

    public void AddPlaylist(Playlist playlist)
    {
        playlists.Add(playlist);
    }

    public Playlist GetPlaylistById(int id)
    {
        return playlists.FirstOrDefault(playlist => playlist.Id == id);
    }

    public void UpdatePlaylist(Playlist updatedPlaylist)
    {
        Playlist existingPlaylist = playlists.FirstOrDefault(playlist => playlist.Id == updatedPlaylist.Id);
        if (existingPlaylist != null)
        {
            existingPlaylist.Name = updatedPlaylist.Name;
            existingPlaylist.Songs = updatedPlaylist.Songs;
        }
    }

    public void DeletePlaylist(int id)
    {
        Playlist playlistToDelete = playlists.FirstOrDefault(playlist => playlist.Id == id);
        if (playlistToDelete != null)
        {
            playlists.Remove(playlistToDelete);
        }
    }

    public void AddSongToPlaylist(int playlistId, Song song)
    {
        Playlist playlist = playlists.FirstOrDefault(pl => pl.Id == playlistId);
        if (playlist != null)
        {
            playlist.Songs.Add(song);
        }
    }

    public void RemoveSongFromPlaylist(int playlistId, int songId)
    {
        Playlist playlist = playlists.FirstOrDefault(pl => pl.Id == playlistId);
        if (playlist != null)
        {
            Song songToRemove = playlist.Songs.FirstOrDefault(song => song.Id == songId);
            if (songToRemove != null)
            {
                playlist.Songs.Remove(songToRemove);
            }
        }
    }
}
