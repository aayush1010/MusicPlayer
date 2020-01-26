using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        private List<Song> favoriteSongs = null;
        private List<Song> allSongs = null;
        private List<IMusicLibrary> allLibraries;

        public MusicPlayer() 
        {
            allLibraries = new List<IMusicLibrary> { new AppMusicLibrary() };
            favoriteSongs = new List<Song>();
            GetAllSongs();
        }

        private void GetAllSongs()
        {
            foreach (var library in allLibraries) 
            {
                allSongs.AddRange(library.GetAllSongs());
            }
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
