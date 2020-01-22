using System.Collections.Generic;

namespace MusicPlayer
{
    public class InternationalMusicLibrary
    {
        private List<Song> songs = new List<Song>();

        private static InternationalMusicLibrary instance = null;

        private static object obj = new object();

        private InternationalMusicLibrary() 
        {
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

        public void AddSong(Song song) 
        {
            songs.Add(song);
        }
    }
}
