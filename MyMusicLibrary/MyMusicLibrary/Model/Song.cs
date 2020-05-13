using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicLibrary.Model
{
    // Album category present in Music Library
    public enum AlbumCategory
    {
        Cinematic,
        Folk,
        Jazz,
        Pop,
        Rock
    }
    public class Song
    {
        public string Title { get; set; }
        public AlbumCategory Category { get; set; }
        public double Duration { get; set; }
        public string Artist { get; set; }
        public string ImageFile { get; set; }
        public string AudioFile { get; set; }


        // create a song global list of all songs present in a music library, for searching feature
        public static List<Song> SongsList = new List<Song>();


        public Song(string title, AlbumCategory category, double duration, string artist)
        {
            Title = title;
            Category = category;
            Duration = duration;
            Artist = artist;
            ImageFile = $"/Assets/Images/{category}/{title}.PNG";
            AudioFile = $"/Assets/Audio/{category}/{title}.mp3";
            SongsList.Add(this);
        }
    }
}
