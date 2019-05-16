using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMovie.Models;
using EMovie.ViewModels;

namespace EMovie.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie {Name ="Damith Movie" };

            var customers = new List<Customer>{
                new Customer { Name = "Damith Chandrasekara"},
                new Customer { Name = "Chandana Prasantha"}
            };
            var viewModel = new RandomViewModel
            {
                Movies = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}