using Class0620024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0620024.Context
{
    public class MediaContext
    {
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; }

        public MediaContext()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie() { Id = 1, Title = "Mission Impossible", Theater = "AMC" });
            Movies.Add(new Movie() { Id = 2, Title = "Mission Impossible 2", Theater = "AMC" });
            Movies.Add(new Movie() { Id = 3, Title = "Mission Impossible 3", Theater = "AMC" });
            Movies.Add(new Movie() { Id = 4, Title = "Mission Impossible 4", Theater = "AMC" });

            Shows = new List<Show>();
            Shows.Add(new Show() { Id = 1, Title = "Law & Order" });
            Shows.Add(new Show() { Id = 2, Title = "Law & Order 2" });
            Shows.Add(new Show() { Id = 3, Title = "Law & Order 3" });
            Shows.Add(new Show() { Id = 4, Title = "Law & Order 4" });

            Videos = new List<Video>();
            Videos.Add(new Video() { Id = 1, Title = "Coding Tutorial" });
            Videos.Add(new Video() { Id = 2, Title = "Coding Tutorial 2" });
            Videos.Add(new Video() { Id = 3, Title = "Coding Tutorial 3" });
            Videos.Add(new Video() { Id = 4, Title = "Coding Tutorial 4" });


        }
    }

}
