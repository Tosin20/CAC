namespace MusicGenre
{


    internal class Program
    {
        internal class NewStream : IMusicPlayer
        {
            internal class MyPlayList : IStreaming
            {
                public string Artiste(string artistName, string albumName)
                {
                    string myArtiste = "Oliver Twist";
                    artistName = myArtiste;
                    string myAlbum = "Rise of the Blues";
                    albumName = myAlbum;
                    return "My favorite artiste is " + artistName + "; My best album is "+ albumName;
                }
            }
            public string Device(string deviceName, string networkSpeed)
            {
                string newDevice = "Samsung S9";
                deviceName = newDevice;
                string newNetworkSpeed = "20Mbps";
                networkSpeed = newNetworkSpeed;
                return deviceName;
            }
        }
        static void Main(string[] args)
        {
            Beat mysong = new Beat();
            mysong.Song();
            mysong.genre();

        }
    }
}