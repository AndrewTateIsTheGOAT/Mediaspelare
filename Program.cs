using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Media> Sounds = new List<Media>()
            {
                new Podcast("Jole", "Bollar", "Pod1", 32, 2023),
                new Podcast("Eddie", "Stål", "Pod2", 21, 2013),
                new Podcast("Manuel", "EK", "Pod3", 20, 2003),
                new Song("Ameen", "javetefan", "Song1", 4, 1992),
                new Song("Sten", "homosapiens", "Song2", 1, 1993),
                new Song("Albert", "Fina du", "Song3", 2, 2004),
                new Movie("filip", "Mekka", "Movie1", 123, 2004),
                new Movie("nathaniel", "hoho", "Movie2", 222, 2006),
                new Movie("vincent", "hehe", "Movie3", 103, 2001),
            };
            for (int i = 0; i < Sounds.Count; i++)
            {
                Sounds[i].PrintMediaInfo();
            }
        }
    }
}
