using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// A simple Asp.net app with a custom route that maps /I/Want/Movies to 
// the MoviesController.Index()action

namespace Asp.netSimpleApp.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
    }
}