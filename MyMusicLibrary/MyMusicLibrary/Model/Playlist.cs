using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicLibrary.Model
{
    // Available options for playlist Cover. User must select from the given list of covers for their playlist.
    public enum PlaylistCover
    {
        Favorite,
        Kids,
        Party,
        Romantic
    }
    public class Playlist
    {
        public string Name { get; set; }
        public int NumOfSongs { get; set; }
        public PlaylistCover Cover { get; set; }
        public string PlaylistCover { get; set; }
        public List<Song> PlaylistSongs { get; set; }


        public Playlist(string name, PlaylistCover cover)
        {
            Name = name;
            PlaylistCover = $"/Assets/Cover/{cover}.PNG";
            this.PlaylistSongs = new List<Song>();

        }
        //Adding song in playlist
        public void AddSong(Song song)
        {
            PlaylistSongs.Add(song);
        }

        //Deleting the song from playlist
        public void DeleteSong(Song song)
        {
            PlaylistSongs.Remove(song);
        }

        //Deleting all the songs from playlist
        public void DeletePlaylist()
        {
            PlaylistSongs.Clear();

        }
    }
    }
