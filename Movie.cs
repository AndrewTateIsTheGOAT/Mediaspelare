using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelare
{
    internal class Movie : Media
    {
        public string _director;

        public Movie(string inputDirector, string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublication) : base(inputTitle, inputFilePath, inputDuration, inputYearOfPublication)
        {
            _director = inputDirector;
        }
        public override void Play()
        {
            Console.WriteLine($"Spelar låten " + Title + " av " + _director);
        }

        public override void Stop()
        {
            Console.WriteLine($"Stoppar låten " + _director);
        }
        public override void PrintMediaInfo()
        {
            Console.WriteLine($"Låt: " + Title + " Director: " + _director + " duration: " + Duration + "min");
        }
    }
}

