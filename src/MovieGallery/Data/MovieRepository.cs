using MovieGallery.Models;
using System.Collections.Generic;

namespace MovieGallery.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie()
            {
                Id = 1,
                Title = "Coco",
                DescriptionHtml = "<p>Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.</p>",
                Genre = "Action & Adventure, Animation, Comedy",
                Director = "Lee Unkrich, Adrian Molina",
                Writer = "Matthew Aldrich, Adrian Molina",
                Studio = "Disney/Pixar"
            },
            new Movie()
            {
                Id = 2,
                Title = "Dunkirk",
                DescriptionHtml = "<p>Allied soldiers from Belgium, the British Empire and France are surrounded by the German Army, and evacuated during a fierce battle in World War II.</p>",
                Genre = "Action & Adventure, Drama",
                Director = "Christopher Nolan",
                Writer = "Christopher Nolan",
                Studio = "Warner Bros. Pictures"
            },
            new Movie()
            {
                Id = 3,
                Title = "Zootopia",
                DescriptionHtml = "<p>In a city of anthropomorphic animals, a rookie bunny cop and a cynical con artist fox must work together to uncover a conspiracy.</p>",
                Genre = "Action & Adventure, Animation, Comedy",
                Director = "Byron Howard, Rich Moore, Jared Bush",
                Writer = "Jared Bush, Phil Johnston",
                Studio = "Walt Disney Animation Studios"
            }
    };

        public Movie GetMovie(int id)
        {
            return _movies.Find(m => m.Id == id);
        }
    }
}