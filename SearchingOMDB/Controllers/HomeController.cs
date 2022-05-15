using Microsoft.AspNetCore.Mvc;
using SearchingOMDB.Models;
using System.Diagnostics;

namespace SearchingOMDB.Controllers
{
    public class HomeController : Controller
    {
        //public List<SearchMovie> MovieList { get; set; } = new List<SearchMovie>();

        public IActionResult Index()
        {
            return View(); // form with two buttons
        }      
    }
}