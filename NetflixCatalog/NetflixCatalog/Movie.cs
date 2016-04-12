using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        int duration;

        public Movie(string Name, int Rating, int Duration)
        {
            name = Name;
            rating = Rating;
            duration = Duration;
        }

        public override string ToString()                   //good
        {
            return string.Format("[{0}, {1} minutes]", name, duration);
        }

        //Movie bourne = new Movie("The Bourne Identity", 5, 123);
        //Movie bourne2 = new Movie("The Bourne Supremacy", 4, 136);
        //Movie bourne3 = new Movie("The Bourne Ultimatum", 5, 132);
        //Movie bourne4 = new Movie("The Bourne Legacy", 4, 130);
        //Movie friday = new Movie("Friday", 5, 102);
        //Movie shades = new Movie("Shades of Grey", 4, 96);
        //Movie harlem = new Movie("Harlem Nights", 5, 120);
        //Movie love = new Movie("Love Jones", 4, 128);
        //Movie scarface = new Movie("Scarface", 5, 154);

    }

}


