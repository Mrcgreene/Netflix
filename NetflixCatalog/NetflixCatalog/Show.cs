using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Show : Title
    {
        //Episode episode;
        public List<Episode> listOfEpisodes;
        public int numberOfEpisodes;

        public Show(string Name, int Rating, int NumberOfEpisodes)
        {
            listOfEpisodes = new List<Episode>();
            name = Name;
            rating = Rating;
            numberOfEpisodes = NumberOfEpisodes;
            //episode = new Episode();
            //overide parent (Title) int rating
        }

        public override string ToString()                               //good
        {
            return string.Format("[{0}, has {1} episodes]", name, numberOfEpisodes);
        }

    }
    //Override parent’s Rating to return an aggregated rating of Episode ratings

}
