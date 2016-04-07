using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Episode
    {
        string name;
        int rating;

        public Episode(string Name, int Rating)
        {
            name = Name;
            rating = Rating;
        }
    }
}
