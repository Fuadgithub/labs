using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.netSimpleApp.Models
{
    public class Repository
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie {Title = "Star Wars", Director = "Lucas"},
                new Movie {Title = "Kind Kong", Director = "jackson"},
                new Movie {Title = "Memento", Director = "Nolan"}
            };
        }
    }
}