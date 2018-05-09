using MovieGallery.Data;
using MovieGallery.Models;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MoviesController : Controller
    {
        private MovieRepository _movieRepository = new MovieRepository();

        public ActionResult Index()
        {
            return View(_movieRepository.GetMovies());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var movie = _movieRepository.GetMovie(id.Value);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }
    }
}