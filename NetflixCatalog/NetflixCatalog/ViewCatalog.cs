using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class ViewCatalog
    {
        Genre genre;

        public ViewCatalog()
        {
            //genre = new Genre();
        }

        public void AddMoviesAndCombineGenres() {

            Genre fantasy = new Genre("Fantasy");
            Genre horror = new Genre("Horror");
            fantasy.listOfTitles.Add(new Movie("Lord of the Rings", 5, 132));
            horror.listOfTitles.Add(new Movie("Spring in Milwaukee", 1, 132));
            Genre fantasyhorror = fantasy + horror;
            foreach (Title title in fantasyhorror.listOfTitles)
            {
                Console.WriteLine(title);
                //fantasy.listOfTitles.Add(title);
            }
        }       

        public void Greeting()
        {
            Console.WriteLine("You have began your search of the Netflix Catalog.");
            Console.WriteLine("You can find a list of titles by simply choosing a genre.");
        }
        public void PrintGenresAndTitles()
        {
            //fix
            Console.WriteLine("Here are the availble genres and the titles within:");
        }
    }
}
