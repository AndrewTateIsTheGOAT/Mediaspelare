using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelare
{
    internal class Media
    {
        private string _title;
        private string _filePath;
        private int _duration;
        private int _yearOfPublication;
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if(value >= 0)
                {
                    _duration = value;
                }
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(value != "")
                {
                    _title = value;
                }
            }
        }

        public string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                if(value != "")
                {
                    _filePath = value;
                }
            }
        }

        public int YearOfPublication
        {
            get
            {
                return _yearOfPublication;
            }
            set
            {
                if (value >= 1900 && value <= 2024)
                {
                    _yearOfPublication = value;
                }
            }
        }

       public Media(string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublication) 
        {
            _title = inputTitle;
            _filePath = inputFilePath;
            _duration = inputDuration;
            _yearOfPublication = inputYearOfPublication;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Spelar media " + _title);
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stoppar media " + _title);
        }
        public virtual void PrintMediaInfo()
        {
            Console.WriteLine($"Låt: " + Title + " Längd: " + Duration + " min, Utgivningsår: " + YearOfPublication);
        }
    }
}
