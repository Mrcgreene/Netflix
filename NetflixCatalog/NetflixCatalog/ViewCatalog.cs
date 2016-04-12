using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class ViewCatalog
    {

        Genre Action;
        Genre Comedy;
        Genre Romance;
        Genre All;

        public ViewCatalog()
        {
            Action = new Genre("Action");
            Comedy = new Genre("Comedy");
            Romance = new Genre("Romance");
            All = new Genre("All");

            //genre = new Genre();
        }

        public void AddMoviesAndCombineGenres()
        {

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

        public void AddMoviesToList()
        {
            Action.listOfTitles.Add(new Movie("The Bourne Identity", 5, 123));
            All.listOfTitles.Add(new Movie("The Bourne Identity", 5, 123));
            Action.listOfTitles.Add(new Movie("The Bourne Supremacy", 4, 136));
            All.listOfTitles.Add(new Movie("The Bourne Supremacy", 4, 136));
            Action.listOfTitles.Add(new Movie("The Bourne Ultimatum", 5, 132));
            All.listOfTitles.Add(new Movie("The Bourne Ultimatum", 5, 132));
            Action.listOfTitles.Add(new Movie("The Bourne Legacy", 4, 130));
            All.listOfTitles.Add(new Movie("The Bourne Legacy", 4, 130));
            Comedy.listOfTitles.Add(new Movie("Friday", 5, 102));
            All.listOfTitles.Add(new Movie("Friday", 5, 102));
            Romance.listOfTitles.Add(new Movie("Shades of Grey", 4, 96));
            All.listOfTitles.Add(new Movie("Shades of Grey", 4, 96));
            Comedy.listOfTitles.Add(new Movie("Harlem Nights", 5, 120));
            All.listOfTitles.Add(new Movie("Harlem Nights", 5, 120));
            Romance.listOfTitles.Add(new Movie("Love Jones", 4, 128));
            All.listOfTitles.Add(new Movie("Love Jones", 4, 128));
            Action.listOfTitles.Add(new Movie("Scarface", 5, 154));
            All.listOfTitles.Add(new Movie("Scarface", 5, 154));
        }

        public void PrintAllTitles()
        {
            Console.WriteLine("Here are all of the available titles:");
            foreach (Title title in All.listOfTitles)
            {
                Console.WriteLine(title.name);
            }
        }

        public void PrintActionTitles()
        {
            Console.WriteLine("Here are the available Action titles:");
            foreach (Title title in Action.listOfTitles)
            {
                Console.WriteLine(title.name);
            }
        }

        public void PrintRomanceTitles()
        {
            Console.WriteLine("Here are the available Romance titles:");
            foreach (Title title in Romance.listOfTitles)
            {
                Console.WriteLine(title.name);
            }
        }

        public void PrintComedyTitles()
        {
            Console.WriteLine("Here are the available Comedy titles:");
            foreach (Title title in Comedy.listOfTitles)
            {
                Console.WriteLine(title.name);
            }
        }

        public void ChooseGenres()
        {
            int decision;
            Console.WriteLine("Which genre would you like to view?");
            Console.WriteLine("(1) All genres");
            Console.WriteLine("(2) Action genre");
            Console.WriteLine("(3) Comedy genre");
            Console.WriteLine("(4) Romance genre");
            decision = Convert.ToInt32(Console.ReadLine());
        }
        public void Start()
        {
            Greeting();
            AddMoviesToList();

        }

    }
}
