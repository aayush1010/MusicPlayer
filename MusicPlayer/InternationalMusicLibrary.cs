using System.Collections.Generic;

namespace MusicPlayer
{
    public class InternationalMusicLibrary
    {
        private List<Song> songs = new List<Song>();

        private static InternationalMusicLibrary instance = null;

        private static object obj = new object();

        private List<IMusicLibrary> musicLibrariesToBeUpdated;

        private InternationalMusicLibrary() 
        {
            musicLibrariesToBeUpdated = new List<IMusicLibrary>();
        }

        public static InternationalMusicLibrary GetInternationalMusicLibraryInstance() 
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new InternationalMusicLibrary();
                    }
                }
            }
            return instance;
        }

        public List<Song> GetSongs() 
        {
            return this.songs;
        }

        public void Subscribe(IMusicLibrary musicLibrary) 
        {
            musicLibrariesToBeUpdated.Add(musicLibrary);
        }

        public void AddSong(Song song) 
        {
            songs.Add(song);
            foreach (var library in musicLibrariesToBeUpdated) 
            {
                library.UpdateMusicLibrary(this);
            }
        }
    }
}
