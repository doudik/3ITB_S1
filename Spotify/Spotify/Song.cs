using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        string songName;
        string artist;
        string album;
        string genre;
        DateTime releaseDate;
        Image coverImage;
        string songPath;
        int songDuration; //int seconds
        
        public Song(string songName, string artist, string album, string genre, DateTime releaseDate, string songPath){
            this.songName = songName;
            this.artist = artist;
            this.album = album;
            this.genre = genre;
            this.releaseDate = releaseDate;
            this.songPath = songPath;
        }
        public Song(Image coverImage) : base() { 
            this.coverImage = coverImage;
        }
    }

}
