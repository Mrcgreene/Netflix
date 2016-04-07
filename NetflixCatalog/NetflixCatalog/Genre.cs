using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{

    public class Genre
    {
        Title title;
        List<Title> listOfTitles;

        public Genre()
        {
            listOfTitles = new List<Title>();
        }

        List<string> romanceGenreList = new List<string>();
        List<string> actionGenreList = new List<string>();
        List<string> comedyGenreList = new List<string>();
        List<string> allGenreList = new List<string>();

       
        public void BrowseTitles()
        {
            //IEnumerator for lists of genres to iterate over titles
        }

    }
}
