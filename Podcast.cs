using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelare
{
    internal class Podcast : Media
    {
        public string _creator;

        public Podcast(string inputCreator, string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublication) : base(inputTitle, inputFilePath, inputDuration, inputYearOfPublication)
        {
            _creator = inputCreator;
        }
        public override void Play()
        {
            Console.WriteLine($"Spelar låten " + Title + " av " + _creator);
        }

        public override void Stop()
        {
            Console.WriteLine($"Stoppar låten " + _creator);
        }
        public override void PrintMediaInfo()
        {
            Console.WriteLine($"Låt: " + Title + " Creator: " + _creator + " duration: " + Duration + "min");
        }
    }
}

