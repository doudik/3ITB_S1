using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class SongManager
    {
        /* 
            1. Add a new song to the list of songs
            2. Remove a song from the list of songs
            3. Play a song
            4. Pause a song
            5. Skip a song
            6. Go back to the previous song
            7. Shuffle the songs
         */
        List <Song> queueList = new List<Song>();
        private SongManager() { } //private constructor
        static SongManager songManager = new SongManager();
        public static SongManager Instance
        {
            get { return songManager; }
            set {
                if (songManager == null)
                {
                    songManager = new SongManager();
                }
            }
        }
        Song currentlyPlayedSong;

        void AddSong(Song song)
        {
            queueList.Add(song);
            if(queueList.Count == 1)
                currentlyPlayedSong = queueList[0];
        }   
        void RemoveSong(Song song)
        {
            if (song == currentlyPlayedSong)
            {
                MessageBox.Show("Cannot remove the song that is currently playing");
            }
            else {
                queueList.Remove(song);
            }
        }
        void ShuffleListSong() { 
            Random rnd = new Random();
            List<Song> tmpList = queueList;

            queueList.Clear();
            while (tmpList.Count > 0) {
                int index = rnd.Next(0, tmpList.Count);

                queueList.Add(tmpList[index]);
                queueList.RemoveAt(index);
            }
            currentlyPlayedSong = queueList[0];
        }
        void PlayNext() { 
            
        }
    }
}
