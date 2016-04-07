using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class View
    {
        Genre genre;

        public View()
        {
            genre = new Genre();
        }
        public void Greeting()
        {
            Console.WriteLine("You have began your search of the Netflix Catalog.");
            Console.WriteLine("You can find a list of titles by simply choosing a genre.");

        }
        public void PrintGenresAndTitles()
        {
            Console.WriteLine("Here are the availble genres and the titles within:");

            

        }
    }
}
