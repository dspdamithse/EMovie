using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMovie.Models;

namespace EMovie.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movies { get; set; }
        public List<Customer> Customers { get; set; }

    }
}