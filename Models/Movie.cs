using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0620024.Models
{
    public class Movie : Media
    {
        public string Theater { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" at {Theater}";
        }
    }

    public class TicketOffice
    {
        List<Movie> Movies { get; set; }

        public void Search(string movieToSearchFor)
        {
            foreach (var movie in Movies)
            {
                // does my movie match movieToSearchFor
            }
        }
    }

}
