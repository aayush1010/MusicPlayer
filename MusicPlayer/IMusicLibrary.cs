using System.Collections.Generic;

namespace MusicPlayer
{
    public interface IMusicLibrary
    {
        public void UpdateMusicLibrary();

        List<Song> GetAllSongs();
    }
}
