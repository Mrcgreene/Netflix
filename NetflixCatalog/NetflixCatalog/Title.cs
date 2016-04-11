using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string name;
        public int? rating;
        string agGenre;

        public Title(string Name, int Rating)                   //good
        {
            name = Name;
            rating = Rating;
        }

        public Title()                                          //good
        {
            name = null;
            rating = null;
        }

        public static Genre operator +(Title title1, Title title2)
        {
            Genre agGenre = new Genre(title1.name + title2.name);

            agGenre.listOfTitles.Add(title1);
            agGenre.listOfTitles.Add(title2);
            //agGenre = title1 + title2;
            //fix 
            return agGenre;
        }


    }
}

