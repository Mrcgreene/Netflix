using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Show showMe = new Show("Grimm",4, 5) ;
            showMe.listOfEpisodes.Add(new Episode("Episode 1", 3));
            showMe.listOfEpisodes.Add(new Episode("Episode 2", 4));

            foreach (Episode title in showMe.listOfEpisodes)
            {
                Console.WriteLine(title.name);
                //fantasy.listOfTitles.Add(title);
            }
            */

            Title testTitle = new Movie("Lord of the Rings", 5, 132);
            Title test2Title = new Movie("Spring in Milwaukee", 1, 132);
            Genre all = new Genre("All");
            Genre fantasy = new Genre("Fantasy");
            Genre horror = new Genre("Horror");
            fantasy.listOfTitles.Add(testTitle);
            all.listOfTitles.Add(testTitle);
            horror.listOfTitles.Add(test2Title);
            all.listOfTitles.Add(test2Title);
            Genre combinedTitles;   //fix
            combinedTitles = testTitle + test2Title;

            foreach (Title title in combinedTitles.listOfTitles)
            {
                Console.WriteLine(title);
                //fantasy.listOfTitles.Add(title);
            }
        }
    }
}
