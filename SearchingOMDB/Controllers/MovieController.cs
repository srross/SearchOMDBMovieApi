using Microsoft.AspNetCore.Mvc;
using SearchingOMDB.Models;
using SearchingOMDB.Models.DataAccess;

namespace SearchingOMDB.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepo _iMovieRepo;

        // degree of separation and separation of concerns
        // dependency injection - controller needs this to call out to the api
        public MovieController(IMovieRepo iMovieRepo) 
        {
            _iMovieRepo = iMovieRepo; 
        }

        // Display Empty Form
        public IActionResult SearchMovie()
        {
            return View();
        }

        // Submit request
        [HttpPost]
        public async Task<IActionResult> SearchMovie(SearchMovie request)
        {
            MovieDetail response = await _iMovieRepo.GetMovie(request.MovieTitle);

            return RedirectToAction("MovieResult", response);
        }

        //  Display response
        public IActionResult MovieResult(MovieDetail movie)
        {
            return View(movie);
        }

        public IActionResult SearchMovieList()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieListResult(SearchMovieList requestList)
        {
            List<MovieDetail> responseMovieList = new List<MovieDetail>();

            responseMovieList.Add(await _iMovieRepo.GetMovie(requestList.MovieTitle1));
            responseMovieList.Add(await _iMovieRepo.GetMovie(requestList.MovieTitle2));
            responseMovieList.Add(await _iMovieRepo.GetMovie(requestList.MovieTitle3));

            return View(responseMovieList);
        }
    }
}