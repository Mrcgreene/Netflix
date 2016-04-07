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
        
        public Show()
        {
            listOfEpisodes = new List<Episode>();
            //episode = new Episode();
            //overide parent (Title) int rating
        }


        public void AddEpisodesToList()
        {
            Episode episode = new Episode("The War to Come", 4);
            Episode episode2 = new Episode("The House of Black and White", 3);
            Episode episode3 = new Episode("High Sparrow", 3);
            Episode episode4 = new Episode("Sons of the Harpy", 3);
            listOfEpisodes.Add(episode);
            listOfEpisodes.Add(episode2);
            listOfEpisodes.Add(episode3);
            listOfEpisodes.Add(episode4);
        }


    }
}
