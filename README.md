# Music Player — Low Level Design

## Problem Statement

Model a music player that can:
1. Aggregate songs across multiple libraries
2. Play songs in order
3. Play a random song
4. Maintain a favorites list
5. Play from favorites
6. Support multiple music companies/labels producing songs

## Design

- **`IMusicLibrary`** — contract for any song source (`GetAllSongs`, `UpdateMusicLibrary`); `AppMusicLibrary` and `InternationalMusicLibrary` are separate implementations so the player isn't tied to one catalog.
- **`MusicPlayer`** — holds all libraries, aggregates their songs, tracks `favoriteSongs` separately from `allSongs`, and exposes sequential (`PlaySongFromMusicLibrary(false)`) and random (`PlaySongFromMusicLibrary(true)`) playback.
- **`IMusicCompany`** — contract for a label that can `CreateAndLaunchNewSong()`; `ColdPlay` is a sample implementation, kept decoupled from the player itself.
- **`Song`** — plain data entity (name, etc.) passed around by the libraries and the player.

This is a work in progress — library aggregation and playback are functional, but the favorites playback path and the music-company integration are stubbed.

## Tech

C# / .NET Core
