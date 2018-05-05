using System;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
            }
            return Content("Hello world.");
        }
    }
}