using System.Collections.Generic;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        private readonly MusicLibrary musicLibrary = null;
        private List<Song> favoriteSongs = null;

        public MusicPlayer() 
        {
            musicLibrary = new MusicLibrary();
            favoriteSongs = new List<Song>();
        }

        public void AddSongToFavorite(Song song) 
        {

        }

        public void PlaySongFromMusicLibrary(bool random) 
        {

        }

        public void PlaySongFromFavorite(bool random) 
        {

        }
    }
}
