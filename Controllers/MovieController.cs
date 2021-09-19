using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {

        public IActionResult Index()  
        {
            MovieStoreContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.MovieStoreContext)) as MovieStoreContext;  
            return View(context.GetMovies());  
        }
    }
}