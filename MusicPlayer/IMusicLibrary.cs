using System.Collections.Generic;

namespace MusicPlayer
{
    public interface IMusicLibrary
    {
        public void UpdateMusicLibrary(InternationalMusicLibrary internationMusicLibrary);

        List<Song> GetAllSongs();
    }
}
