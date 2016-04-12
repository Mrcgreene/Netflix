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


        
    }
}
