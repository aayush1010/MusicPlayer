using System;

namespace MusicPlayer
{
    class ColdPlay : IMusicCompany
    {
        public void CreateAndLaunchNewSong()
        {
            var song = new Song(1, "Sky full Of stars", Constants.Genre.Jazz);

        }
    }
}
