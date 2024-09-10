using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelare
{
    internal class Song : Media
    {
        public string _artist;

        public Song(string inputArtist, string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublication) : base(inputTitle, inputFilePath, inputDuration, inputYearOfPublication)
            {
            _artist = inputArtist;
            }
        public override void Play()
        {
            Console.WriteLine($"Spelar låten " + Title + " av " + _artist);
        }

        public override void Stop()
        {
            Console.WriteLine($"Stoppar låten " + _artist);
        }
        public override void PrintMediaInfo()
        {
            Console.WriteLine($"Låt: " + Title + " Artist: " + _artist + " duration: " + Duration + "min");
        }
    }
}
