using System.Collections.Generic;

namespace MusicPlayer
{
    public class AppMusicLibrary : IMusicLibrary
    {
        private List<Song> songs { get; set; }

        public AppMusicLibrary()
        {
            songs = new List<Song>();
        }

        public void UpdateMusicLibrary(InternationalMusicLibrary internationMusicLibrary)
        {
            songs = internationMusicLibrary.GetSongs();
        }

        public List<Song> GetAllSongs()
        {
            return this.songs;
        }
    }
}
