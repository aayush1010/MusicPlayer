namespace MusicPlayer
{
    class ColdPlay : IMusicCompany
    {
        private InternationalMusicLibrary internationalMusicLibrary = null;

        public ColdPlay()
        {
            internationalMusicLibrary = InternationalMusicLibrary.GetInternationalMusicLibraryInstance();
        }

        public void CreateAndLaunchNewSong()
        {
            var song = new Song(1, "Sky full Of stars", Constants.Genre.Jazz);
            internationalMusicLibrary.AddSong(song);
        }
    }
}
