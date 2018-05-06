using System;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Coco";
            ViewBag.Description = "<p>Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.</p>";
            ViewBag.MovieInfo = new string[]
            {
                "Genre: Action & Adventure, Animation, Comedy",
                "Directed By: Lee Unkrich, Adrian Molina",
                "Written By: Matthew Aldrich, Adrian Molina",
                "Studio: Disney/Pixar"
            };

            return View();
        }
    }
}