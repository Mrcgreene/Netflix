using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{

    public class Genre : IEnumerable
    {
        public string genreName;
        public string titleName;
        public Title title;
        public List<Title> listOfTitles;

        public Genre(string GenreName)
        {
            genreName = GenreName;
            listOfTitles = new List<Title>();
        }

        public static Genre operator +(Genre a, Genre b)            //good
        {
            Genre newGenre = new Genre(a.genreName + b.genreName);

            foreach (Title title in a.listOfTitles)
            {
                newGenre.listOfTitles.Add(title);
            }
            foreach (Title title in b.listOfTitles)
            {
                newGenre.listOfTitles.Add(title);
            }
            return newGenre;
        }

        
    public static Genre operator +(Genre a, Title b)                //good
    {
        Genre newGenre = new Genre(a.genreName + b.name);

        foreach (Title title in a.listOfTitles)
        {
            newGenre.listOfTitles.Add(title);
        }
            newGenre.listOfTitles.Add(b);
        return newGenre;
    }
      
        public IEnumerator GetEnumerator()                          //good
        {
            for(int i =0; i < listOfTitles.Count; i++)
            {
                yield return listOfTitles[i];
                yield return "\n";
            }
            yield return "There Are No More Titles";
        }


        //Genre Scifi = new Genre("Scifi");
        //Genre Fantasy = new Genre("Fantasy");
        //Genre Horror = new Genre("Horror");
        //Genre Drama = new Genre("Drama");
        //Genre Action = new Genre("The Bourne Identity");
        //Genre Comedy = new Genre("Comedy");
        //Genre Romance = new Genre("Romance");
        //Scifi.listOfTitles.Add(new Movie("Blade Runner", 4, 179));
        //Scifi.listOfTitles.Add(new Movie("Star Wars", 5, 125));
        //this.listOfTitles.Add(new Movie("Lord of the Rings", 5, 132));
        //Horror.listOfTitles.Add(new Movie("Nightmare On Elm Street", 4, 122));
        //Action.listOfTitles.Add(new Movie("The Bourne Identity", 5, 123));
        //Action.listOfTitles.Add(new Movie("The Bourne Supremacy", 4, 136));
        //Action.listOfTitles.Add(new Movie("The Bourne Ultimatum", 5, 132));
        //Action.listOfTitles.Add(new Movie("The Bourne Legacy", 4, 130));
        //Comedy.listOfTitles.Add(new Movie("Friday", 5, 102));
        //Romance.listOfTitles.Add(new Movie("Shades of Grey", 4, 96));
        //Comedy.listOfTitles.Add(new Movie("Harlem Nights", 5, 120));
        //Romance.listOfTitles.Add(new Movie("Love Jones", 4, 128));
        //Action.listOfTitles.Add(new Movie("Scarface", 5, 154));
    }
}
