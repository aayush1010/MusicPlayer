using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        private List<Song> favoriteSongs = null;
        private List<Song> allSongs = null;
        private List<IMusicLibrary> allLibraries;
        private Random rnd;
        private int songPlaying;

        public MusicPlayer()
        {
            songPlaying = default(int);
            allLibraries = new List<IMusicLibrary> { new AppMusicLibrary() };
            favoriteSongs = new List<Song>();
            rnd = new Random();
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
            favoriteSongs.Add(song);
        }

        public void PlaySongFromMusicLibrary(bool random)
        {
            if (!random)
            {
                Console.WriteLine("Song played : " + allSongs[songPlaying].SongName());
                songPlaying++;
            }
            else
            {
                var ranSong = rnd.Next(1, allSongs.Count + 1);
                Console.WriteLine("Song played : " + allSongs[ranSong].SongName());
            }
        }

        public void PlayAllSongs() 
        {
            foreach(var song in allSongs) 
            {
                PlaySongFromMusicLibrary(false);
            }
        }

        public void PlaySongFromFavorite(bool random)
        {

        }
    }
}
