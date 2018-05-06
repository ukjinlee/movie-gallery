using MovieGallery.Models;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Detail()
        {
            var movie = new Movie()
            {
                Title = "Coco",
                DescriptionHtml = "<p>Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.</p>",
                Genre = "Action & Adventure, Animation, Comedy",
                Director = "Lee Unkrich, Adrian Molina",
                Writer = "Matthew Aldrich, Adrian Molina",
                Studio = "Disney/Pixar"
            };

            return View(movie);
        }
    }
}