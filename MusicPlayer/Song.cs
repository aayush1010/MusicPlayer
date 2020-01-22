using System;

namespace MusicPlayer
{
    public class Song
    {
        private readonly int songId;
        private readonly string name;
        private readonly Constants.Genre genre;
        private readonly DateTime releaseDate;

        public Song(int songId, string name, Constants.Genre genre) 
        {
            this.songId = songId;
            this.name = name;
            this.genre = genre;
            this.releaseDate = DateTime.Now;
        }
    }
}
