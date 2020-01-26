using System.Collections.Generic;

namespace MusicPlayer
{
    public class AppMusicLibrary : IMusicLibrary
    {
        private List<Song> songs { get; set; }

        private InternationalMusicLibrary internationMusicLibrary;

        public AppMusicLibrary()
        {
            songs = new List<Song>();
            internationMusicLibrary = InternationalMusicLibrary.GetInternationalMusicLibraryInstance();
            internationMusicLibrary.Subscribe(this);
        }

        public void UpdateMusicLibrary()
        {
            songs = internationMusicLibrary.GetSongs();
        }

        public List<Song> GetAllSongs()
        {
            return this.songs;
        }
    }
}
