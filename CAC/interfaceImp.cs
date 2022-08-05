using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenre
{
    internal interface IMusicPlayer
    {
        public string Device(string deviceName, string networkSpeed);
    }
    public interface IStreaming
    {
        public string Artiste(string artistName, string albumName);
    }
}
