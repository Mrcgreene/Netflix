using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        string duration;

        public Movie(string Name, int Rating, string Duration)
        {
            name = Name;
            rating = Rating;
            duration = Duration;
        }


        //Movie bourne = new Movie("The Bourne Identity", 5, "123 minutes");
        //Movie bourne2 = new Movie("The Bourne Supremacy", 4, "136 minutes");
        //Movie bourne3 = new Movie("The Bourne Ultimatum", 5, "132 minutes");
        //Movie bourne4 = new Movie("The Bourne Legacy", 4, "130 minutes");
        //Movie friday = new Movie("Friday", 5, "102 minutes");
        //Movie shades = new Movie("Shades of Grey", 4, "96 minutes");
        //Movie harlem = new Movie("Harlem Nights", 5, "120 minutes");
        //Movie love = new Movie("Love Jones", 4, "128 minutes");
        //Movie scarface = new Movie("Scarface", 5, "154 minutes");

    }
    
    
}
