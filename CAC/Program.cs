using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenre
{
    
    internal abstract class Music
    {
        
        public abstract void Song();
        public void genre()
        {
            Console.WriteLine("Genre: It is R&B");
        }
    }
    
    class Beat : Music
    {
        public override void Song()
        {
            Console.WriteLine("Beat is slow:");
        }
    }

}