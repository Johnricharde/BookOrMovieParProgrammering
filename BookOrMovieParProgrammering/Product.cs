using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrMovieParProgrammering
{
    public class Product
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nTitle:            {Title}");
            Console.WriteLine($"Released:           {ReleaseYear}");
            Console.WriteLine($"Director/Writer:    {Director}");
            if (!String.IsNullOrEmpty(""))
            {
                Console.WriteLine($"Actors:             {string.Join(", ", Actors)}");
            }
            Console.WriteLine($"Description:        {Description}");
        }
    }
}
